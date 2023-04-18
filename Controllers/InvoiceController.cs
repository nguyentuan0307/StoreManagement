using Azure.Core;
using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services;
using ComputerRepair.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace ComputerRepair.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly ICustomerService _customerService;
        private readonly IRequestService _requestService;
        private readonly IDeviceService _deviceService;
        private readonly IServiceService _serviceService;
        public InvoiceController(IInvoiceService invoiceService, ICustomerService customerService, IRequestService requestService, IDeviceService deviceService, IServiceService serviceService)
        {
            _invoiceService = invoiceService;
            _customerService = customerService;
            _requestService = requestService;
            _deviceService = deviceService;
            _serviceService = serviceService;
        }
        public IActionResult Index()
        {
            var invoices = _invoiceService.GetInvoices();
            var customers = _customerService.GetCustomers();
            var invoicesView = new List<InvoiceView>();
            foreach (var invoice in invoices)
            {
                invoicesView.Add(new InvoiceView
                {
                    InvoiceID = invoice.InvoiceID,
                    CustomerName = invoice.Customer.CustomerName,
                    InvoiceDate = invoice.InvoiceDate,
                    TotalPrice = invoice.TotalPrice,
                });
            }
            return View(invoicesView);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var customers = _customerService.GetCustomers();
            ViewBag.Customers = customers;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerView customerView)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("CompleteCreate", new { customerId = customerView.CustomerID });
            }
            return View();
        }
        [HttpGet]
        public IActionResult CompleteCreate(int customerId)
        {
            var customer = _customerService.GetCustomer(customerId);
            var devices = _deviceService.GetDevices();
            var services = _serviceService.GetServices();
            if (customer == null)
            {
                return NotFound();
            }
            ViewBag.Customer = customer;
            ViewBag.Devices = devices;
            ViewBag.Services = services;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CompleteCreate()
        {
            using (var reader = new StreamReader(Request.Body))
            {
                var requestBody = await reader.ReadToEndAsync();
                var request = JsonConvert.DeserializeObject<InvoiceDetails>(requestBody);
                // Tiếp tục xử lý invoice ở đây
                Invoice invoice = new Invoice()
                {
                    CustomerID = Int32.Parse(request.CustomerID),
                    TotalPrice = request.TotalPrice,
                    InvoiceDate = request.InvoiceDate,
                };
                int invoiceID = _invoiceService.Addinvoice(invoice);
                foreach (var i in request.serviceAndDevices)
                {
                    var requestToDB = new Requestx()
                    {
                        DeviceID = i.DeviceID,
                        ServiceID = i.ServiceID,
                        Quantity = i.Quantity,
                        Price = i.Price,
                        InvoiceID = invoiceID
                    };
                    _requestService.Addrequest(requestToDB);
                }
                if (ModelState.IsValid)
                {
                    return Json(new { url = Url.Action("InvoiceDetail", "Invoice", new { id = invoiceID }) });
                }
                else
                {
                    Console.WriteLine("123qwe");
                    return View();
                }
            }
        }
        [HttpGet]
        public IActionResult InvoiceDetail(int id)
        {
            var devices = _deviceService.GetDevices();
            var services = _serviceService.GetServices();
            var invoice = _invoiceService.Getinvoice(id);
            Customer customer = _customerService.GetCustomer(invoice.CustomerID);
            var requestx = _requestService.GetRequestxByInvoiceId(id);
            ViewBag.Invoice = invoice;
            ViewBag.Customer = customer;
            ViewBag.Requestx = requestx;
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var invoice = _invoiceService.Getinvoice(id);
            var requestx = _requestService.GetRequestxByInvoiceId(id);
            if (_requestService.DeleteRequestxByInvoiceId(id))
            {
                if (_invoiceService.Deleteinvoice(id))
                {

                }
            }
            return RedirectToAction("Index");
        }
    }
}
