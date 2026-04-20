using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Tienda_Lego.Models
{
    public class CartItems: BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Users User { get; set; } = new Users();
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Products Product { get; set; } = new Products();
        public int Quantity = 0;

    }
}
