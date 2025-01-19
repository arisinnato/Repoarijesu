using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configurations
{    public class ObjetoConfiguration : IEntityTypeConfiguration<Objetos>
    {
        public void Configure(EntityTypeBuilder<Objetos> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.Nombre).IsRequired().HasMaxLength(15);
            builder.Property(o => o.Descripcion).HasMaxLength(600);
            builder.Property(o => o.Tipo).IsRequired().HasMaxLength(50);
            builder.ToTable("Objetos");
        }
    }
}