using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class CartItems: BaseEntity
    {
        [Required]
        public Users user = new Users();
        [Required]
        public ICollection<Products>? product ;
        public int Quantity = 0;

    }
}
