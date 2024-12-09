
using System.ComponentModel.DataAnnotations;

namespace BackendGestorDeGastos.Models
{
    public class TipoGasto
    {
        [Key]
        public int IdTipo { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; } = null!;
    }
}