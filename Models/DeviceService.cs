namespace ComputerRepair.Models
{
    public class DeviceService
    {
        public DeviceService()
        {
            Requests = new HashSet<Request> { };
        }
        public int DeviceServiceID { get; set; }
        public int Price { get; set; }
        public int ServiceID { get; set; }
        public Service? Service { get; set; }
        public int DeviceID { get; set; }
        public Device? Device { get; set; }
        public HashSet<Request> Requests { get; set; }
    }
}
