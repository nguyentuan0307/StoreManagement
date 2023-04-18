using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IInvoiceService
    {
        List<Invoice> GetInvoices();
        int Addinvoice(Invoice invoice);
        bool Saveinvoice(Invoice invoice);
        bool Deleteinvoice(int id);
        Invoice Getinvoice(int id);
    }
}
