using ComputerRepair.Data;
using ComputerRepair.DTO;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ComputerRepair.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddNewUser(User user)
        {
            if (CheckHasUser(user.Username))
            {
                return false;
            }
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteUser(int id)
        {
            User user = _dataContext.Users.Where(s => s.UserID == id).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();
            return true;
        }

        public User GetUser(int id)
        {
            return _dataContext.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return _dataContext.Users.ToList();
        }

        public bool SaveUser(User user)
        {
            User userTemp = _dataContext.Users.Find(user.UserID);
            if (userTemp != null)
            {
                userTemp.Username = user.Username;
                userTemp.Password = user.Password;
                userTemp.Email = user.Email;
                userTemp.FullName = user.FullName;
                userTemp.Phone = user.Phone;
                userTemp.Address = user.Address;
                userTemp.RoleID = user.RoleID;
                _dataContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckHasUser(string username)
        {
            return _dataContext.Users.Any(u => u.Username == username);
        }
        public int GetRoleAccount(string username, string password)
        {
            User user = _dataContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user == null)
            {
                return 0;
            }
            return user.RoleID;
        }
    }
}