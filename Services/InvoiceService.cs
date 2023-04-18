using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class invoiceService : IInvoiceService
    {
        private readonly DataContext _dataContext;
        public invoiceService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public int Addinvoice(Invoice invoice)
        {
            _dataContext.Invoices.Add(invoice);
            _dataContext.SaveChanges();
            return invoice.InvoiceID;
        }

        public bool Deleteinvoice(int id)
        {
            Invoice invoice = _dataContext.Invoices.Where(s => s.InvoiceID == id).FirstOrDefault();
            if (invoice == null)
            {
                return false;
            }
            _dataContext.Invoices.Remove(invoice);
            _dataContext.SaveChanges();
            return true;
        }

        public Invoice Getinvoice(int id)
        {
            return _dataContext.Invoices.Find(id);
        }

        public List<Invoice> GetInvoices()
        {
            return _dataContext.Invoices.ToList();
        }

        public bool Saveinvoice(Invoice invoice)
        {
            Invoice invoiceTemp = _dataContext.Invoices.Find(invoice.InvoiceID);
            if (invoiceTemp != null)
            {
                invoiceTemp.CustomerID = invoice.CustomerID;
                invoiceTemp.InvoiceDate = invoice.InvoiceDate;
                invoiceTemp.TotalPrice = invoice.TotalPrice;
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
