using System.Collections.Generic;
using BackendGestorDeGastos.Models;
using Microsoft.EntityFrameworkCore;
namespace BackendGestorDeGastos.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Persona> Personas { get; set; } = null!;
    public DbSet<Gasto> Gasto { get; set; } = null!;
    public DbSet<DetalleGasto> DetallesGasto { get; set; } = null!;
    public DbSet<Alertas> Alertas { get; set; } = null!;
}
