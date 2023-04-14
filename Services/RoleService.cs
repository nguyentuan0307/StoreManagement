using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services.IServices;

namespace ComputerRepair.Services
{
    public class RoleService : IRoleService
    {
        private readonly DataContext _dataContext;
        public RoleService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void AddNewRole(Role role)
        {
            _dataContext.Roles.Add(role);
            _dataContext.SaveChanges();
        }

        public void DeleteRole(int id)
        {
            Role role = _dataContext.Roles.Where(s => s.RoleID == id).FirstOrDefault();
            _dataContext.Roles.Remove(role);
            _dataContext.SaveChanges();
        }

        public Role GetRole(int id)
        {
            return _dataContext.Roles.Find(id);
        }

        public List<Role> GetRoles()
        {
            return _dataContext.Roles.ToList();
        }

        public void SaveRole(Role role)
        {
            Role roleTemp = _dataContext.Roles.Find(role.RoleID);
            roleTemp.RoleName = role.RoleName;
            _dataContext.SaveChanges();
        }
    }
}
