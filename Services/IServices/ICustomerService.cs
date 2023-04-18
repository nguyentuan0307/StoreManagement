using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        bool AddCustomer(Customer customer);
        bool SaveCustomer(Customer customer);
        bool DeleteCustomer(int id);
        Customer GetCustomer(int id);
    }
}
