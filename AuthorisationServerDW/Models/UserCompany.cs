using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorisationServerDW.Models
{
    public class UserCompany
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Companies")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
