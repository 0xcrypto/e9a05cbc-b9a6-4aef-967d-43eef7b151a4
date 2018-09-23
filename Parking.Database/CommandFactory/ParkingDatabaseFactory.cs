using Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Parking.Common;

namespace Parking.Database.CommandFactory
{
    public class ParkingDatabaseFactory: IParkingDatabaseFactory
    {
        private readonly ISqlDataAccess sqlDataAccess;
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>();
        private const string MasterId = "4D587294-4DC1-421A-8FB5-D5DE9FB0ED4A";
        private const int TicketNumberLength = 10;

        public ParkingDatabaseFactory()
        {
            sqlDataAccess = new SqlDataAccess();
            queries.Add("SelectMasterSettings", @"SELECT  
                                                        [CompanyName],
                                                        [ParkingPlaceCode],
                                                        [ParkingPlaceName],
                                                        [TwoWheelerParkingRatePerHour],
                                                        [FourWheelerParkingRatePerHour],
                                                        [LostTicketPenality],
                                                        [PLCBoardPortNumber]
                                                FROM [tbl_master] 
                                                WHERE [Id] = '{0}'");

            queries.Add("UpdateMasterSettings", @"  UPDATE [tbl_master]
                                                    SET 
                                                        [CompanyName] = '{0}',
                                                        [ParkingPlaceCode] = '{1}',
                                                        [ParkingPlaceName] = '{2}',
                                                        [TwoWheelerParkingRatePerHour] = '{3}',
                                                        [FourWheelerParkingRatePerHour] = '{4}',
                                                        [LostTicketPenality] = '{5}',
                                                        [PLCBoardPortNumber] = '{6}' 
                                                    WHERE [Id] = '{7}'");

            queries.Add("InsertVehicleEntry", @"INSERT INTO [tbl_parking]
                                                            ([TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime]) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')");

        }


        public void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality,
            string plcBoardPortNumber)
        {
            var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                      twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, plcBoardPortNumber,
                                      MasterId);
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

        public void SaveVehicleEntry(string vehicleNumber)
        {
            var ticketNumber = AlphaNumericCode.GenerateRandomNumber(TicketNumberLength);
            var entryTime = DateTime.Now;
            // ToDo: Add uniqueness on validation number
            var validationNumber = AlphaNumericCode.GenerateRandomNumber(TicketNumberLength);
            var qrCode = QrCode.GenerateQrCode(vehicleNumber, validationNumber);
            const string vehicleType = "Car";

            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], ticketNumber, validationNumber, qrCode, vehicleNumber,
                                                vehicleType, entryTime);
                sqlDataAccess.ExecuteNonQuery(insertQuery);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}