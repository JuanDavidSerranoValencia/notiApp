using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GenericVsSubmoduloConfiguration : IEntityTypeConfiguration<GenericVsSubmodulo>
    {
        public void Configure(EntityTypeBuilder<GenericVsSubmodulo> builder)
        {
            builder.ToTable("genericvssubmodulo");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(p => p.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Rol)
            .WithMany(p => p.GenericsVsSubmodulos)
            .HasForeignKey(p => p.IdRolFk);

            builder.HasOne(p => p.PermisoGenerico)
            .WithMany(p => p.GenericsVsSubmodulos)
            .HasForeignKey(p => p.IdPermisoGenericoFk);

             builder.HasOne(p => p.MaestroVsSubmodulo)
            .WithMany(p => p.GenericsVsSubmodulos)
            .HasForeignKey(p => p.IdMaestroSubmoduloFk);



        }
    }
}