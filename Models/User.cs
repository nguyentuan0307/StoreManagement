using System.Data;

namespace ComputerRepair.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int RoleID { get; set; }
        public Role? Role { get; set; }
    }
}
