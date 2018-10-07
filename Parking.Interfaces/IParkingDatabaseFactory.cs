using Parking.Common.Model;
using System;
using System.Data;
using System.Drawing;

namespace Parking.Interfaces
{
    public interface IParkingDatabaseFactory
    {
        void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality);

        DataRow GetMasterSettings();

        Ticket SaveVehicleEntry(string deviceId, string vehicleNumber, int vehicleType, string parkingCharges, string mPSDeviceId);

        string GetUniqueCode();
    }
}