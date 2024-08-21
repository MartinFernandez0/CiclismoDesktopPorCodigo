using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosArgentina;

public partial class ArgentinaContext : DbContext
{
    public ArgentinaContext()
    {
    }

    public ArgentinaContext(DbContextOptions<ArgentinaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Argentina;User Id=sa;Password=123;MultipleActiveResultSets=true;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Departamento");

            entity.Property(e => e.Nombre).HasMaxLength(250);

            entity.HasOne(d => d.Provincias).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.ProvinciasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamentos_Provincias");
        });

        modelBuilder.Entity<Localidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Localidad");

            entity.Property(e => e.Nombre).HasMaxLength(250);

            entity.HasOne(d => d.Departamentos).WithMany(p => p.Localidades)
                .HasForeignKey(d => d.DepartamentosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Localidades_Departamentos");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Provincia");

            entity.Property(e => e.Nombre).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
