using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerRepair.Controllers
{
    [Authorize]
    public class DeviceController : Controller
    {
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        public IActionResult Index()
        {
            var devices = _deviceService.GetDevices();
            var devicesView = new List<DeviceView>();
            foreach (var device in devices)
            {
                devicesView.Add(new DeviceView
                {
                    DeviceID = device.DeviceID,
                    DeviceName = device.DeviceName,
                    Description = device.Description,
                    Manufacturer = device.Manufacturer,
                    Quantity = device.Quantity,
                });
            }
            return View(devicesView);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Add(Device device)
        {
            if (!_deviceService.AddNewDevice(device))
            {
                // Thêm bị lỗi
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id)
        {
            var device = _deviceService.GetDevice(id);
            return View(device);
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Update(Device device)
        {
            if (!_deviceService.SaveDevice(device))
            {
                // xử lý lỗi ở đây
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (!_deviceService.DeleteDevice(id))
            {

            }
            return RedirectToAction("Index");
        }
    }
}
