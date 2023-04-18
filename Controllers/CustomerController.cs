using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services;
using ComputerRepair.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerRepair.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            var customers = _customerService.GetCustomers();
            var customersView = new List<CustomerView>();
            foreach (var customer in customers)
            {
                customersView.Add(new CustomerView
                {
                    CustomerID = customer.CustomerID,
                    CustomerName = customer.CustomerName,
                    Phone = customer.Phone,
                    Email = customer.Email,
                    Address = customer.Address,
                });
            }
            return View(customersView);
        }
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Add(Customer customer)
        {
            if (!_customerService.AddCustomer(customer))
            {
                // Thêm bị lỗi
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize]
        public IActionResult Update(int id)
        {
            var customer = _customerService.GetCustomer(id);
            return View(customer);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Update(Customer customer)
        {
            if (!_customerService.SaveCustomer(customer))
            {
                // xử lý lỗi ở đây
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (!_customerService.DeleteCustomer(id))
            {

            }
            return RedirectToAction("Index");
        }
    }
}
