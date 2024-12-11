
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGestorDeGastos.Models
{
    public class Persona
    {
        [Key]
        [Required]
        [StringLength(50)]
        [ForeignKey("Usuario")]
        public string RutUsuario { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public Usuario Usuario { get; set; } = null!;
    }
}