namespace ComputerRepair.Models
{
    public class Device
    {
        public Device()
        {
            deviceServices = new HashSet<DeviceService> { };
        }
        public int DeviceID { get; set; }
        public string? DeviceName { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public int Quantity { get; set; }
        public HashSet<DeviceService> deviceServices { get; set; }
    }
}
