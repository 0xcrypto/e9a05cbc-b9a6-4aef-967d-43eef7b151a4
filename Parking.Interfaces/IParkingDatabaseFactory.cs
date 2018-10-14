using Parking.Common.Enums;
using Parking.Common.Model;
using System.Data;

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

        void SaveVehicleEntry(string deviceId, Ticket ticket);

        string GetUniqueCode();
    }
}