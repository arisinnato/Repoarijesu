using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using core.Entidades;

namespace infrastructure.Data.Configurations
{
    public class MisionesConfiguracion : IEntityTypeConfiguration<Mision>
    {
        public void Configure(EntityTypeBuilder<Mision> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Descripcion).HasMaxLength(600);
            builder.Property(m => m.Recompensas).HasMaxLength(255);     
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(15);


             // No estoy seguro si implemente bien el metodo de transformacion de datos pero supongo que si porque no me lanza error :))
            builder.Property(m => m.Objetivos).HasConversion(objetivos => string.Join(",", objetivos),str => str.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()).HasColumnType("TEXT");                   
            builder.ToTable("Mision");
        }

    }
}