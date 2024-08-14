using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class Cliente
{
    public int Id { get; set; } = 0;

    public string? Nombre { get; set; }

    public string? NombreContacto { get; set; }

    public string? ApellidoContacto { get; set; }

    public string? TituloContacto { get; set; }

    public string? CargoContacto { get; set; }

    public string? GerenteDeCuenta { get; set; }

    public decimal? VentasAnioAnterior { get; set; }

    public string? Direccion1 { get; set; }

    public string? Direccion2 { get; set; }

    public string? Ciudad { get; set; }

    public string? Region { get; set; }

    public string? Pais { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
