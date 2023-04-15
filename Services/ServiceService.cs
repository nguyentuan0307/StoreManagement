using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class ServiceService : IServiceService
    {
        private readonly DataContext _dataContext;
        public ServiceService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddNewSevice(Service service)
        {
            _dataContext.Services.Add(service);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteSevice(int id)
        {
            Service service = _dataContext.Services.Where(s => s.ServiceID == id).FirstOrDefault();
            if (service == null)
            {
                return false;
            }
            _dataContext.Services.Remove(service);
            _dataContext.SaveChanges();
            return true;
        }

        public Service GetService(int id)
        {
            return _dataContext.Services.Find(id);
        }

        public List<Service> GetServices()
        {
            return _dataContext.Services.ToList();
        }

        public bool SaveSevice(Service service)
        {
            Service seviceTemp = _dataContext.Services.Find(service.ServiceID);
            if (seviceTemp != null)
            {
                seviceTemp.ServiceName = service.ServiceName;
                seviceTemp.Description = service.Description;
                _dataContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
