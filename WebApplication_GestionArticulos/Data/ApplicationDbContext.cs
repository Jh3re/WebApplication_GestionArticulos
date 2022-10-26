using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication_GestionArticulos.Models;

namespace WebApplication_GestionArticulos.Data
{
    public partial class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<ArticuloEtiqueta> ArticuloEtiqueta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<DetalleUsuario> DetalleUsuario { get; set; }
        public DbSet<Etiqueta> Etiqueta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticuloEtiqueta>().HasKey(ae => new { ae.Etiqueta_Id, ae.Articulo_Id });
        }
    }
}
