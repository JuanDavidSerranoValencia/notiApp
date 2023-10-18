
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class NotiAppContext : DbContext
{
    public NotiAppContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<GenericVsSubmodulo> GenericVsSubmodulos { get; set; }
    public DbSet<MaestroVsSubmodulo> MaestroVsSubmodulos { get; set; }
    public DbSet<ModuloMaestro> ModuloMaestros { get; set; }
    public DbSet<PermisoGenerico> permisoGenericos { get; set; }
    public DbSet<Rol> Rols { get; set; }
    public DbSet<RolVsMaestro> RolVsMaestros { get; set; }
    public DbSet<Submodulo> Submodulos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
