using BackendGestorDeGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendGestorDeGastos.Data // Asegúrate de que el espacio de nombres sea correcto
{
    public class BackendGestorDeGastosContext : DbContext
    {
        public BackendGestorDeGastosContext(DbContextOptions<BackendGestorDeGastosContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } // Ajusta las entidades según tu modelo
    }
}
