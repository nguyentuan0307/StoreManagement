using ComputerRepair.DTO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ComputerRepair.Services.IServices;
using ComputerRepair.Models;

namespace ComputerRepair.Controllers
{
    public class HomeController : Controller
    {
        IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginView model)
        {
            if (ModelState.IsValid)
            {
                var role = _userService.GetRoleAccount(model.Username, model.Password);
                if (role != 0)
                {
                    // Đăng nhập thành công
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username),
                        new Claim(ClaimTypes.Role, role == 1 ? "admin" : "employee") // thêm quyền vào claim
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        // Chuyển hướng đến trang người dùng muốn truy cập nếu có
                        RedirectUri = "/Home/Index"
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErrorMessage"] = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                }
            }

            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "User");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode.Value == 404)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                // Các xử lý lỗi khác ở đây
            }
            return View();
        }

    }
}
