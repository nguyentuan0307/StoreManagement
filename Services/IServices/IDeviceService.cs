using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IDeviceService
    {
        List<Device> GetDevices();
        Device GetDevice(int id);
        int GetQuantityDevice(int id);
        bool UpdateQuantityDevice(int id,int count);
        bool AddNewDevice(Device device);
        bool DeleteDevice(int id);
        bool SaveDevice(Device device);
    }
}
