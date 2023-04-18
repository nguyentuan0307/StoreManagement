namespace ComputerRepair.Models
{
    public class Service
    {
        public Service()
        {
            Requests = new HashSet<Requestx> { };
        }
        public int ServiceID { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }
        public HashSet<Requestx> Requests { get; set; }

    }
}
