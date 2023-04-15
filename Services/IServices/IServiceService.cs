using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IServiceService
    {
        List<Service> GetServices();
        Service GetService(int id);
        bool AddNewSevice(Service service);
        bool DeleteSevice(int id);
        bool SaveSevice(Service service);
    }
}
