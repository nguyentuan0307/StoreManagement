using ComputerRepair.Models;

namespace ComputerRepair.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? RoleName { get; set; }
    }
}
