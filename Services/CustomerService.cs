using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _dataContext;
        public CustomerService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddCustomer(Customer customer)
        {
            _dataContext.Customers.Add(customer);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteCustomer(int id)
        {
            Customer customer = _dataContext.Customers.Where(s => s.CustomerID == id).FirstOrDefault();
            if (customer == null)
            {
                return false;
            }
            _dataContext.Customers.Remove(customer);
            _dataContext.SaveChanges();
            return true;
        }

        public Customer GetCustomer(int id)
        {
            return _dataContext.Customers.Find(id);
        }

        public List<Customer> GetCustomers()
        {
            return _dataContext.Customers.ToList();
        }

        public bool SaveCustomer(Customer customer)
        {
            Customer customerTemp = _dataContext.Customers.Find(customer.CustomerID);
            if (customerTemp != null)
            {
                customerTemp.CustomerName = customer.CustomerName;
                customerTemp.Phone = customer.Phone;
                customerTemp.Email = customer.Email;
                customerTemp.Address = customer.Address;
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
