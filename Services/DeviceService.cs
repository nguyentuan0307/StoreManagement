using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly DataContext _dataContext;
        public DeviceService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddNewDevice(Device device)
        {
            _dataContext.Devices.Add(device);
            _dataContext.SaveChanges();
            return true;
        }

        public Device GetDevice(int id)
        {
            return _dataContext.Devices.Find(id);
        }

        public List<Device> GetDevices()
        {
            return _dataContext.Devices.ToList();
        }

        public bool DeleteDevice(int id)
        {
            Device device = _dataContext.Devices.Where(s => s.DeviceID == id).FirstOrDefault();
            if (device == null)
            {
                return false;
            }
            _dataContext.Devices.Remove(device);
            _dataContext.SaveChanges();
            return true;
        }

        public bool SaveDevice(Device device)
        {
            Device deviceTemp = _dataContext.Devices.Find(device.DeviceID);
            if (deviceTemp != null)
            {
                deviceTemp.DeviceName = device.DeviceName;
                deviceTemp.Description = device.Description;
                deviceTemp.Manufacturer = device.Manufacturer;
                deviceTemp.Quantity = device.Quantity;
                _dataContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetQuantityDevice(int id)
        {
            Device deviceTemp = _dataContext.Devices.Find(id);
            return deviceTemp.Quantity;
        }
        public bool UpdateQuantityDevice(int id, int count)
        {
            Device deviceTemp = _dataContext.Devices.Find(id);
            if (count > deviceTemp.Quantity)
            {
                return false;
            }
            deviceTemp.Quantity -= count;
            _dataContext.SaveChanges();
            return true;
        }

    }
}
