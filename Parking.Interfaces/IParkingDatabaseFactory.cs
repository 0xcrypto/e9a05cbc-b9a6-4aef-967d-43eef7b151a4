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
            string TDClientVehicleCameraPassword);

        DataRow GetMasterSettings();

        void SaveVehicleEntry(string vehicleNumber);
    }
}