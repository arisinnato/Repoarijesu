using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;
using infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Personaje> Personajes {get;set;}
        public DbSet<Mision> Misiones {get;set;}
        public DbSet<Objetos> Objetos {get;set;}
        public DbSet<Enemigos> Enemigos {get;set;}
        public DbSet<Habilidades> Habilidades {get;set;}
        public DbSet<Equipamiento> Equipamientos {get;set;}
        public DbSet<Ubicaciones> Ubicaciones{get;set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.ApplyConfiguration(new PersonajeConfiguration());
            builder.ApplyConfiguration(new MisionesConfiguracion());
            builder.ApplyConfiguration(new ObjetoConfiguration());
            builder.ApplyConfiguration(new EnemigoConfiguration());
            builder.ApplyConfiguration(new HabilidadConfiguration());
            builder.ApplyConfiguration(new EquipamientoConfiguration());
            builder.ApplyConfiguration(new UbicacionesConfiguracion());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
        optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}