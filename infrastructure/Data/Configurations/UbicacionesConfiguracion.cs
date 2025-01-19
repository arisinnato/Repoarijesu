using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configurations
{
    public class UbicacionesConfiguracion : IEntityTypeConfiguration<Ubicaciones>
    {
        public void Configure(EntityTypeBuilder<Ubicaciones> builder){
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.nombre).IsRequired().HasMaxLength(15); 
            builder.Property(x => x.descripcion) .IsRequired().HasMaxLength(500); ;    
        }
    }
}