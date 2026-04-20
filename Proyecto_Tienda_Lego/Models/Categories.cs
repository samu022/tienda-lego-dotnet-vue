using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class Categories: BaseEntity
    {
        [Required]
        public string Category { get; set; } = string.Empty;
    }
}
