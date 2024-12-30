
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGestorDeGastos.Models
{
    public class Alertas
    {
        [Key]
        public int IdAlerta { get; set; }

        [Required]
        public string ListadoDeCorreos { get; set; } = null!;

        [Required]
        [ForeignKey("Usuario")]
        public string RutUsuarioCreadorAlerta { get; set; } = null!;

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public DateTime FechaNotificacion { get; set; }

        public Usuario Usuario { get; set; } = null!;
    }
}