using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class Products: BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name = string.Empty;
        [StringLength(1000)]
        public string Description = string.Empty;
        [Required]
        public float Price;
        [Required]
        public int Stock;
        [Required]
        public Categories Category=new Categories();
        public string? Image_URL;
    }
}