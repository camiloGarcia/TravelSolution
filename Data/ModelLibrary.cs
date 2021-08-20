using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public partial class ModelLibrary : DbContext
    {
        public ModelLibrary()
            : base("name=ModelLibrary")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelLibrary, Data.Migrations.Configuration>());
        }

        public virtual DbSet<autor> autores { get; set; }
        public virtual DbSet<autor_has_libro> autores_has_libros { get; set; }
        public virtual DbSet<editorial> editoriales { get; set; }
        public virtual DbSet<libro> libros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<autor>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<autor>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<editorial>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<editorial>()
                .Property(e => e.sede)
                .IsUnicode(false);

            modelBuilder.Entity<editorial>()
                .HasMany(e => e.libros)
                .WithOptional(e => e.editorial)
                .HasForeignKey(e => e.editorial_id);

            modelBuilder.Entity<libro>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<libro>()
                .Property(e => e.sinopsis)
                .IsUnicode(false);
        }
    }
}
