using Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Parking.Common;
using System.Drawing;
using System.IO;
using Parking.Common.Model;

namespace Parking.Database.CommandFactory
{
    public class ParkingDatabaseFactory : IParkingDatabaseFactory
    {
        private readonly ISqlDataAccess sqlDataAccess;
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>();
        private const string MasterId = "4D587294-4DC1-421A-8FB5-D5DE9FB0ED4A";

        public ParkingDatabaseFactory()
        {
            sqlDataAccess = new SqlDataAccess();
            queries.Add("SelectMasterSettings", @"SELECT  [CompanyName],
                                                          [ParkingPlaceCode],
                                                          [ParkingPlaceName],
                                                          [TwoWheelerParkingRatePerHour],
                                                          [FourWheelerParkingRatePerHour],
                                                          [LostTicketPenality]
                                                FROM [tbl_master] 
                                                WHERE [Id] = '{0}'");

            queries.Add("UpdateMasterSettings", @"  UPDATE [tbl_master]
                                                    SET [CompanyName] = '{0}', 
                                                        [ParkingPlaceCode] = '{1}', 
                                                        [ParkingPlaceName] = '{2}', 
                                                        [TwoWheelerParkingRatePerHour] = '{3}', 
                                                        [FourWheelerParkingRatePerHour] = '{4}', 
                                                        [LostTicketPenality] = '{5}', 
                                                    WHERE [Id] = '{6}'");

            queries.Add("InsertVehicleEntry", @"INSERT INTO [tbl_parking]
                                                            ([DeviceId],
                                                             [TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime],
                                                             [DriverImage],
                                                             [VehicleImage]) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}', '{8}')");

        }


        public void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality)
        {
            var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                      twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, MasterId);
            sqlDataAccess.ExecuteNonQuery(query);
        }

        public DataRow GetMasterSettings()
        {
            try
            {
                var query = string.Format(queries["SelectMasterSettings"], MasterId);

                var sqlCommand = sqlDataAccess.GetCommand(query);

                var result = sqlDataAccess.Execute(sqlCommand);

                return result.Rows[0];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        public Ticket SaveVehicleEntry(string deviceId, string vehicleNumber, int vehicleType)
        {
            var ticketNumber = new UniqueCode().GenerateCode();
            var validationNumber = new UniqueCode().GenerateCode();
            var entryTime = DateTime.Now.ToString();
            var qrCode = QRCode.GenerateQRCode(vehicleNumber, validationNumber, vehicleType, entryTime);
            var qrCodeImage = QRCode.GetQRCodeImage(qrCode);
            var driverImage = (Image)IPCamera.GetDriverImage();
            var vehicleImage = (Image)IPCamera.GetVehicleImage();

            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], deviceId, 
                    ticketNumber, validationNumber, qrCode, vehicleNumber, vehicleType, entryTime, driverImage, vehicleImage);
                sqlDataAccess.ExecuteNonQuery(insertQuery);

                return new Ticket()
                {
                    TicketNumber = ticketNumber,
                    ValidationNumber = validationNumber,
                    VehicleNumber = vehicleNumber,
                    QRCodeImage = qrCodeImage,
                    QRCode = qrCode,
                    EntryTime = entryTime
                };
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}