using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Numero de serie")]
        public string NumeroSerie { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Precio")]
        public double Precion { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Costo")]
        public double Costo { get; set; }
        
        public string Imagen { get; set; }

        //relacion
        [Required]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        [Required]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        //recursividad
        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }
    }
}
