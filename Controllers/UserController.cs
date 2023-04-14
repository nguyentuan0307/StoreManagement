﻿using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;
using ComputerRepair.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ComputerRepair.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public UserController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            var users = _userService.GetUsers();
            var roles = _roleService.GetRoles();
            var usersDTO = new List<UserDTO>();
            foreach (var user in users)
            {
                usersDTO.Add(new UserDTO
                {
                    UserID = user.UserID,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    FullName = user.FullName,
                    Phone = user.Phone,
                    Address = user.Address,
                    RoleName = user.Role?.RoleName,
                });
            }
            return View(usersDTO);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var roles = _roleService.GetRoles();
            return View(roles);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            if (!_userService.AddNewUser(user))
            {
                // Thêm bị lỗi
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CheckHasUser(string username)
        {
            bool hasUser = _userService.CheckHasUser(username);

            if (!hasUser)
            {
                return Content("Username is already taken.");
            }
            else
            {
                return Content("Username is available.");
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var roles = _roleService.GetRoles();
            var user = _userService.GetUser(id);
            ViewBag.user = user;
            return View(roles);
        }
        [HttpPost]
        public IActionResult Update(User user)
        {
            if (!_userService.SaveUser(user))
            {
                // xử lý lỗi ở đây
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!_userService.DeleteUser(id))
            {

            }
            return RedirectToAction("Index");
        }
    }
}