using ComputerRepair.Models;

namespace ComputerRepair.Services.IServices
{
    public interface IRoleService
    {
        List<Role> GetRoles();
        void AddNewRole(Role role);
        Role GetRole(int id);
        void SaveRole(Role role);
        void DeleteRole(int id);
    }
}
