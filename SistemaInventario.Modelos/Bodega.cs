using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Nombre")]
        public String Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Descripcion")]
        public String Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
