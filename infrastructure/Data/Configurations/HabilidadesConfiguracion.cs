using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configurations
{
    public class HabilidadConfiguration : IEntityTypeConfiguration<Habilidades>
    {
        public void Configure(EntityTypeBuilder<Habilidades> builder)
        {
 
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id).UseIdentityColumn();
            builder.Property(h => h.Nombre).IsRequired().HasMaxLength(15);                                     
            builder.Property(h => h.Descripcion).HasMaxLength(60);                   
            builder.Property(h => h.CostoEnergia).IsRequired();                  
            builder.Property(h => h.DañoBase).IsRequired();                   
            builder.Property(h => h.Curacion) .IsRequired();                  
            builder.Property(h => h.Enfriamiento) .IsRequired();                 
            builder.Property(h => h.Tipo) .IsRequired() .HasMaxLength(40);
            builder.ToTable("Habilidades");
        }
    }
}