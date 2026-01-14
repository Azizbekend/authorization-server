using System.ComponentModel.DataAnnotations;

namespace AuthorisationServerDW.Models
{
    public class BaseRole
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
