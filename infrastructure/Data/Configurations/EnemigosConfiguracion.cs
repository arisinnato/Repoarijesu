using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configurations
{
    public class EnemigoConfiguration : IEntityTypeConfiguration<Enemigos>
    {
        public void Configure(EntityTypeBuilder<Enemigos> builder)
        {
            // Clave primaria
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(15);
            builder.Property(e => e.NivelDAmenaza).IsRequired();
            builder.Property(e => e.Recompensa) .IsRequired();     
            builder.HasMany(e => e.Habilidades).WithOne().OnDelete(DeleteBehavior.Cascade);    
            builder.Property(e => e.Salud).IsRequired();                   
            builder.Property(e => e.Energia).IsRequired();                  
            builder.Property(e => e.Fuerza).IsRequired();      
            builder.Property(e => e.Inteligencia) .IsRequired();
            builder.Property(e => e.Agilidad) .IsRequired();                 
            builder.ToTable("Enemigos");
        }
    }
}