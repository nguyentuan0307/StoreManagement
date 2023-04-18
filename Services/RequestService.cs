using Azure.Core;
using ComputerRepair.Data;
using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class requestService : IRequestService
    {
        private readonly DataContext _dataContext;
        public requestService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool Addrequest(Requestx request)
        {
            _dataContext.Requests.Add(request);
            _dataContext.SaveChanges();
            return true;
        }

        public bool Deleterequest(int id)
        {
            Requestx request = _dataContext.Requests.Where(s => s.RequestxID == id).FirstOrDefault();
            if (request == null)
            {
                return false;
            }
            _dataContext.Requests.Remove(request);
            _dataContext.SaveChanges();
            return true;
        }

        public Requestx Getrequest(int id)
        {
            return _dataContext.Requests.Find(id);
        }

        public List<Requestx> Getrequests()
        {
            return _dataContext.Requests.ToList();
        }

        public List<Requestx> GetRequestxByInvoiceId(int id)
        {
            return _dataContext.Requests.Where(r => r.InvoiceID == id).ToList();
        }
        public decimal GetTotalInvoice(int id)
        {
            List<decimal> totalList = _dataContext.Requests.Select(r => r.Price).ToList();
            return totalList.Sum();
        }
        public bool Saverequest(Requestx request)
        {
            Requestx requestTemp = _dataContext.Requests.Find(request.RequestxID);
            if (requestTemp != null)
            {
                requestTemp.ServiceID = request.ServiceID;
                requestTemp.DeviceID = request.DeviceID;
                requestTemp.Quantity = request.Quantity;
                requestTemp.InvoiceID = request.InvoiceID;
                request.Price = request.Price;
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteRequestxByInvoiceId(int id)
        {
            List<Requestx> requestxs = _dataContext.Requests.Where(r => r.InvoiceID == id).ToList();
            if (requestxs == null)
            {
                return false;
            }
            _dataContext.Requests.RemoveRange(requestxs);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
