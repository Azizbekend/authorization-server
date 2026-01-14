using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorisationServerDW.Models
{
    public class UserModules
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public User User { get; set; }

        public bool JboModule { get; set; } = false;
        public bool LaboratoryModule { get; set; } = false;
        public bool DigitalizationMapModule { get; set; } = false;

    }
}
