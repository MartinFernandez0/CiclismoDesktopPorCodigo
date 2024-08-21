using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosCiclismo;

public partial class CiclismoRenzo2Context : DbContext
{
    public CiclismoRenzo2Context()
    {
    }

    public CiclismoRenzo2Context(DbContextOptions<CiclismoRenzo2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DireccionEmpleado> DireccionEmpleados { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<TipoProducto> TipoProductos { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CiclismoRenzo-2;User Id=sa;Password=123; multipleactiveresultsets=true; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApellidoContacto).HasMaxLength(30);
            entity.Property(e => e.CargoContacto).HasMaxLength(30);
            entity.Property(e => e.Ciudad).HasMaxLength(20);
            entity.Property(e => e.CodigoPostal).HasMaxLength(10);
            entity.Property(e => e.Direccion1).HasMaxLength(60);
            entity.Property(e => e.Direccion2).HasMaxLength(20);
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.GerenteDeCuenta).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(40);
            entity.Property(e => e.NombreContacto).HasMaxLength(30);
            entity.Property(e => e.Pais).HasMaxLength(15);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TituloContacto).HasMaxLength(5);
            entity.Property(e => e.VentasAnioAnterior).HasColumnType("money");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Idproducto);

            entity.Property(e => e.Idproducto)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDProducto");
            entity.Property(e => e.FechaDeOrden).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEsperadaDeAtencion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.IdproductoNavigation).WithOne(p => p.Compra)
                .HasForeignKey<Compra>(d => d.Idproducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compras_Productos");
        });

        modelBuilder.Entity<DireccionEmpleado>(entity =>
        {
            entity.HasKey(e => e.Idempleado);

            entity.ToTable("Direccion_Empleados");

            entity.Property(e => e.Idempleado)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDEmpleado");
            entity.Property(e => e.Ciudad).HasMaxLength(15);
            entity.Property(e => e.Codigopostal).HasMaxLength(10);
            entity.Property(e => e.Direccion1).HasMaxLength(60);
            entity.Property(e => e.Direccion2).HasMaxLength(20);
            entity.Property(e => e.Pais).HasMaxLength(15);
            entity.Property(e => e.Region).HasMaxLength(15);

            entity.HasOne(d => d.IdempleadoNavigation).WithOne(p => p.DireccionEmpleado)
                .HasForeignKey<DireccionEmpleado>(d => d.Idempleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Direccion_Empleados_Empleados");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anexo).HasMaxLength(4);
            entity.Property(e => e.Apellido).HasMaxLength(20);
            entity.Property(e => e.Cargo).HasMaxLength(30);
            entity.Property(e => e.FechaDeIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDeNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre).HasMaxLength(10);
            entity.Property(e => e.TelefonoDomicilio).HasMaxLength(20);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClaseProducto).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.Idproveedor).HasColumnName("IDProveedor");
            entity.Property(e => e.IdtipoProducto).HasColumnName("IDTipoProducto");
            entity.Property(e => e.MF)
                .HasMaxLength(10)
                .HasColumnName("M_F");
            entity.Property(e => e.NombreProducto).HasMaxLength(50);
            entity.Property(e => e.Precio).HasColumnType("money");
            entity.Property(e => e.Talla).HasMaxLength(10);

            entity.HasOne(d => d.IdtipoProductoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdtipoProducto)
                .HasConstraintName("FK_Productos_Tipo_Productos");
        });

        modelBuilder.Entity<TipoProducto>(entity =>
        {
            entity.ToTable("Tipo_Productos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnType("ntext");
            entity.Property(e => e.NombreTipoProducto).HasMaxLength(50);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CasillaPostal).HasMaxLength(50);
            entity.Property(e => e.EmpresaEnvio).HasMaxLength(20);
            entity.Property(e => e.FechaAtencionSolicitada).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDespacho).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPedido).HasColumnType("smalldatetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idempleado).HasColumnName("IDEmpleado");
            entity.Property(e => e.VentaTotal).HasColumnType("money");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Ventas_Clientes");

            entity.HasOne(d => d.IdempleadoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idempleado)
                .HasConstraintName("FK_Ventas_Empleados");
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ventas_Detalle");

            entity.Property(e => e.Idproducto).HasColumnName("IDProducto");
            entity.Property(e => e.Idventa).HasColumnName("IDVenta");
            entity.Property(e => e.PrecioUnitario).HasColumnType("money");

            entity.HasOne(d => d.IdproductoNavigation).WithMany()
                .HasForeignKey(d => d.Idproducto)
                .HasConstraintName("FK_Ventas_Detalle_Productos");

            entity.HasOne(d => d.IdventaNavigation).WithMany()
                .HasForeignKey(d => d.Idventa)
                .HasConstraintName("FK_Ventas_Detalle_Ventas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
