using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configurations
{
    public class EquipamientoConfiguration : IEntityTypeConfiguration<Equipamiento>
    {
        public void Configure(EntityTypeBuilder<Equipamiento> builder)
        {
            // Clave primaria
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(20);                                      
            builder.Property(e => e.Casco).HasMaxLength(20);                   
            builder.Property(e => e.Coraza).HasMaxLength(20);                   
            builder.Property(e => e.Arma1).HasMaxLength(20);                  
            builder.Property(e => e.Arma2) .HasMaxLength(20);                  
            builder.Property(e => e.Guanteletes) .HasMaxLength(20);                  
            builder.Property(e => e.Grebas) .HasMaxLength(20);                 
            builder.Property(e => e.Estadisticas) .HasMaxLength(500);
            builder.ToTable("Equipamiento");
        }
    }
}