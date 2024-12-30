using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGestorDeGastos.Models
{
    public class DetalleGasto
    {
        [Key]
        public int IdDetalleGasto { get; set; }

        [Required]
        [ForeignKey("Gasto")]
        public int IdGasto { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public string RutUsuario { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MontoGasto { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Required]
        public bool EstadoPago { get; set; }

        public byte[]? ImagenDeCobroGasto { get; set; }
        public byte[]? ImagenDePagoGasto { get; set; }

        // Nuevas columnas provenientes de TipoGasto
        [Required]
        public int idtipo { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; } = null!;

        // Relaciones
        public Gasto Gasto { get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;
    }
}