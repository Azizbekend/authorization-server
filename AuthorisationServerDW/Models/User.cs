using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorisationServerDW.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Login { get; set; }
        [MaxLength(20)]
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public bool IsEmailApproved { get; set; }
        [ForeignKey("BaseRoles")]
        public int BaseRoleId { get; set; }
        public BaseRole BaseRole { get; set; }
    }
}
