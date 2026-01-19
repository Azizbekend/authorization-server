using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorisationServerDW.DTOs
{
    public class UserCreateDTO
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public bool IsEmailApproved { get; set; } = false;
        public int BaseRoleId { get; set; }
    }
}
