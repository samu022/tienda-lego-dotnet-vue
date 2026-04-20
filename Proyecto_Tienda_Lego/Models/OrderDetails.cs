using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class OrderDetails: BaseEntity
    {
        [Required]
        public Orders Order { get; set; } = new Orders();
        [Required]
        public Products Product { get; set; } = new Products();
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity;

    }
}
