using ComputerRepair.DTO;
using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int id);
        bool AddNewUser(User user);
        bool SaveUser(User user);
        bool DeleteUser(int id);
        bool CheckHasUser(string username);
        int GetRoleAccount(string username, string password);
    }
}
