using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Tienda_Lego.Models
{
    public class Orders: BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Users User { get; set; } = new Users();

        [Required]
        public float Total { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
