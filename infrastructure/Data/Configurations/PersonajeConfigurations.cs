using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using core.Entidades;

namespace infrastructure.Data.Configurations
{
    public class PersonajeConfiguration : IEntityTypeConfiguration<Personaje>
    {
        public void Configure(EntityTypeBuilder<Personaje> builder){
            
            
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.nombre).IsRequired().HasMaxLength(15); 
            builder.Property(x => x.nivel) .IsRequired();    
            builder.Property(x => x.vida).IsRequired(); 
            builder.Property(x => x.energia).IsRequired();               
            builder.Property(x => x.fuerza) .IsRequired();
            builder.Property(x => x.inteligencia).IsRequired();
            builder.Property(x => x.habilidad) .IsRequired();
            builder.Property(x => x.experiencia).IsRequired();
            builder.HasMany(p => p.Equipamiento).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Habilidades).WithOne().OnDelete(DeleteBehavior.Cascade);   
            builder.ToTable("Personaje");


        }

    }
}