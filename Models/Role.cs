namespace ComputerRepair.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public HashSet<User> Users { get; set; }
    }
}
