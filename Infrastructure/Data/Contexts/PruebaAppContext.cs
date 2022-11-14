using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Contexts
{
    public partial class PruebaAppContext: DbContext
    {


        public PruebaAppContext()
        {
        }

        public PruebaAppContext(DbContextOptions<PruebaAppContext> options) : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_CARGO");

                entity.ToTable("Cargo");

                entity.Property(e => e.Activo).HasDefaultValueSql("((0))");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.Nombre)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_DEPARTAMENTO");

                entity.ToTable("Departamento");

                entity.Property(e => e.Activo).HasDefaultValueSql("((0))");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.Nombre)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_USUARIO");

                entity.ToTable("Usuario");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_DEPARTAMENTO");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_CARGO");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
