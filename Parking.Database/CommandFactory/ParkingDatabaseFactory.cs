﻿using Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Parking.Common;
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
                                                            ([TDClientDeviceId],
                                                             [TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime],
                                                             [DriverImage],
                                                             [VehicleImage],
                                                             [IsParkingEntryDetailsUploadedToServer],
                                                             [IsParkingExitDetailsUploadedToServer])
                                                            
                                                              
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')");

            queries.Add("GetUniqueCode", @"select cast((Abs(Checksum(NewId()))%10) as varchar(1)) +  char(ascii('a') + (Abs(Checksum(NewId()))%25)) + 
                                                char(ascii('A')+(Abs(Checksum(NewId()))%25)) + left(newid(),5) as UniqueCode");
        }

        public void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality)
        {
            try
            {
                var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                          twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, MasterId);
                sqlDataAccess.ExecuteNonQuery(query);

            }
            catch (Exception exception)
            {
                FileLogger.Log($"TDClient Master settings could not be updated successfully to database as : {exception.Message}");
                throw;
            }
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
                FileLogger.Log($"TDClient Master settings could not be loaded successfully from database as : {exception.Message}");
                throw;
            }

        }

        public void SaveVehicleEntry(string deviceId, Ticket ticket)
        {            
            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], deviceId,
                    ticket.TicketNumber, ticket.ValidationNumber, ticket.QRCode, ticket.VehicleNumber, (int)ticket.VehicleType, ticket.EntryTime, ticket.DriverImage, ticket.VehicleImage, 0, 0);
                sqlDataAccess.ExecuteNonQuery(insertQuery);
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Ticket Information Could not be saved in database as : {exception.Message}");
                throw;
            }
        }

        public string GetUniqueCode()
        {
            var sqlCommand = sqlDataAccess.GetCommand(queries["GetUniqueCode"]);
            var dataRow = sqlDataAccess.Execute(sqlCommand).Rows[0];
            return dataRow[0].ToString();
        }
    }
}