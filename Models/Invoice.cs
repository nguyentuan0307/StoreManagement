namespace ComputerRepair.Models
{
    public class Invoice
    {
        public Invoice()
        {
            Requests = new HashSet<Request>();
        }
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }

        public Customer? Customer { get; set; }
        public HashSet<Request> Requests { get; set; }
    }
}
