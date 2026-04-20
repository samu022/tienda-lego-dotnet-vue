using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Tienda_Lego.Models
{
    public class OrderDetails: BaseEntity
    {
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Orders Order { get; set; } = new Orders();

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Products Product { get; set; } = new Products();

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}
