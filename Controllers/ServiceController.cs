using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services;
using ComputerRepair.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerRepair.Controllers
{
    [Authorize]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IActionResult Index()
        {
            var services = _serviceService.GetServices();
            var servicesView = new List<ServiceView>();
            foreach (var service in services)
            {
                servicesView.Add(new ServiceView
                {
                    ServiceID = service.ServiceID,
                    ServiceName = service.ServiceName,
                    Description = service.Description,
                });
            }
            return View(servicesView);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Add(Service service)
        {
            if (!_serviceService.AddNewSevice(service))
            {
                // Thêm bị lỗi
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id)
        {
            var service = _serviceService.GetService(id);
            return View(service);
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Update(Service service)
        {
            if (!_serviceService.SaveSevice(service))
            {
                // xử lý lỗi ở đây
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (!_serviceService.DeleteSevice(id))
            {

            }
            return RedirectToAction("Index");
        }
    }
}
