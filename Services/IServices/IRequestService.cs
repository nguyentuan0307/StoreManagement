using ComputerRepair.DTO;
using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IRequestService
    {
        List<Requestx> Getrequests();
        bool Addrequest(Requestx request);
        bool Saverequest(Requestx request);
        bool Deleterequest(int id);
        Requestx Getrequest(int id);
        List<Requestx> GetRequestxByInvoiceId(int id);
        bool DeleteRequestxByInvoiceId(int id);
        decimal GetTotalInvoice(int id);
    }
}
