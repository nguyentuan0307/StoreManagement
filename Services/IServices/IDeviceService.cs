using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IDeviceService
    {
        List<Device> GetDevices();
        Device GetDevice(int id);
        bool AddNewDevice(Device device);
        bool DeleteDevice(int id);
        bool SaveDevice(Device device);
    }
}
