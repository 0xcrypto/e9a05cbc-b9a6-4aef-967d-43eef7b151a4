using Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Parking.Common;
using Parking.CameraCommunicate;
using System.Drawing;
using System.IO;

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
            queries.Add("SelectMasterSettings", @"SELECT  [CompanyName],
                                                          [ParkingPlaceCode],
                                                          [ParkingPlaceName],
                                                          [TwoWheelerParkingRatePerHour],
                                                          [FourWheelerParkingRatePerHour],
                                                          [LostTicketPenality],
                                                          [TDClientPLCBoardPortNumber], 
                                                          [TDServerIPAddress], 
                                                          [TDServerPortNumber], 
                                                          [TDClientDeviceId], 
                                                          [TDClientUserId], 
                                                          [TDClientPassword], 
                                                          [TDClientLongLat], 
                                                          [TDClientDriverCameraIPAddress], 
                                                          [TDClientDriverCameraUserId], 
                                                          [TDClientDriverCameraPassword], 
                                                          [TDClientVehicleCameraIPAddress], 
                                                          [TDClientVehicleCameraUserId], 
                                                          [TDClientVehicleCameraPassword]
                                                FROM [tbl_master] 
                                                WHERE [Id] = '{0}'");

            queries.Add("UpdateMasterSettings", @"  UPDATE [tbl_master]
                                                    SET [CompanyName] = '{0}', 
                                                        [ParkingPlaceCode] = '{1}', 
                                                        [ParkingPlaceName] = '{2}', 
                                                        [TwoWheelerParkingRatePerHour] = '{3}', 
                                                        [FourWheelerParkingRatePerHour] = '{4}', 
                                                        [LostTicketPenality] = '{5}', 
                                                        [TDClientPLCBoardPortNumber] = '{6}', 
                                                        [TDServerIPAddress] = '{7}', 
                                                        [TDServerPortNumber] = '{8}', 
                                                        [TDClientDeviceId] = '{9}', 
                                                        [TDClientUserId] = '{10}', 
                                                        [TDClientPassword] = '{11}', 
                                                        [TDClientLongLat] = '{12}',  
                                                        [TDClientDriverCameraIPAddress] = '{13}',  
                                                        [TDClientDriverCameraUserId] = '{14}',  
                                                        [TDClientDriverCameraPassword] = '{15}',  
                                                        [TDClientVehicleCameraIPAddress] = '{16}',  
                                                        [TDClientVehicleCameraUserId] = '{17}', 
                                                        [TDClientVehicleCameraPassword] = '{18}' 
                                                    WHERE [Id] = '{19}'");

            queries.Add("InsertVehicleEntry", @"INSERT INTO [tbl_parking]
                                                            ([TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime],
                                                             [DriverImage],
                                                             [VehicleImage]) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}')");

        }


        public void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality,
            string TDClientPLCBoardPortNumber,
            string TDServerIPAddress,
            string TDServerPortNumber,
            string TDClientDeviceId,
            string TDClientUserId,
            string TDClientPassword,
            string TDClientLongLat,
            string TDClientDriverCameraIPAddress,
            string TDClientDriverCameraUserId,
            string TDClientDriverCameraPassword,
            string TDClientVehicleCameraIPAddress,
            string TDClientVehicleCameraUserId,
            string TDClientVehicleCameraPassword)
        {
            var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                      twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, TDClientPLCBoardPortNumber,
                                      TDServerIPAddress, TDServerPortNumber, TDClientDeviceId, TDClientUserId, TDClientPassword,
                                      TDClientLongLat, TDClientDriverCameraIPAddress, TDClientDriverCameraUserId, TDClientDriverCameraPassword,
                                      TDClientVehicleCameraIPAddress, TDClientVehicleCameraUserId, TDClientVehicleCameraPassword, 
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

        public void SaveVehicleEntry(string vehicleNumber, int vehicleType)
        {
            var ticketNumber = AlphaNumericCode.GenerateRandomNumber(TicketNumberLength);
            var validationNumber = AlphaNumericCode.GenerateRandomNumber(TicketNumberLength);
            var entryTime = DateTime.Now.ToString();
            var code = QRCode.Generate(vehicleNumber, validationNumber, vehicleType, entryTime);
            var driverImage = (Image)ParkingCamera.GetDriverImage();
            var vehicleImage = (Image)ParkingCamera.GetVehicleImage();

            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], ticketNumber, validationNumber, code, vehicleNumber, vehicleType, entryTime, driverImage, vehicleImage);
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