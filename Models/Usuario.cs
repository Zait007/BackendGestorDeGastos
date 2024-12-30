
using System.ComponentModel.DataAnnotations;


namespace BackendGestorDeGastos.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string RutUsuario { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Clave { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Correo { get; set; } = null!;
    }
}