using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Lego.Models
{
    public class Orders: BaseEntity
    {
        [Required]
        public Users User { get; set; } = new Users();
        [Required]
        public float Total;
        [Required]
        public int Status;
    }
}
