namespace ComputerRepair.Models
{
    public class Service
    {
        public Service()
        {
            deviceServices = new HashSet<DeviceService> { };
        }
        public int ServiceID { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }
        public HashSet<DeviceService> deviceServices { get; set; }

    }
}
