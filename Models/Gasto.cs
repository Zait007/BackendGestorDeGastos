
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGestorDeGastos.Models
{
    public class Gasto
    {
        [Key]
        public int IdGasto { get; set; }



        [Required]
        [ForeignKey("Usuario")]
        public string RutUsuario { get; set; } = null!;

        [Required]
        public DateTime FechaDeCobro { get; set; }

        [Required]
        public DateTime FechaPago { get; set; }

        [Required]
        public bool Activo { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}