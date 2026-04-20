using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class Roles:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Role { get; set; } = string.Empty;
    }
}
