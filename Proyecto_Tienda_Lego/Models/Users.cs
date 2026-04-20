using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class Users : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;
        [PasswordPropertyText]
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public Roles rol=new Roles();



    }
}
