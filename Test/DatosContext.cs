using Microsoft.EntityFrameworkCore;

namespace SGE.Repositorios;
using SGE.Aplicacion;

public class DatosContext : DbContext
{
    public DbSet<Expediente> Expedientes {get; set;}
    public DbSet<Tramite> Tramites {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Datos.sqlite");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expediente>().HasMany(e => e.Tramites).WithOne(t => t.expediente).OnDelete(DeleteBehavior.ClientCascade);
    }

}