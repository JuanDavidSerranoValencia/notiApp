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
    public class RolVsMaestroConfiguration : IEntityTypeConfiguration<RolVsMaestro>
    {
        public void Configure(EntityTypeBuilder<RolVsMaestro> builder)
        {
             builder.ToTable("rolvsmaestro");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(p => p.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Rol)
            .WithMany(p => p.RolsVsMaestros)
            .HasForeignKey(p => p.IdRolFk);

            builder.HasOne(p => p.ModuloMaestro)
            .WithMany(p => p.RolsVsMaestros)
            .HasForeignKey(p => p.IdModuloMaestroFk);
        }
    }
}