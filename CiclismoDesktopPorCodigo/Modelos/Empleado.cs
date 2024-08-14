using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class Empleado
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Cargo { get; set; }

    public DateTime? FechaDeNacimiento { get; set; }

    public DateTime? FechaDeIngreso { get; set; }

    public string? TelefonoDomicilio { get; set; }

    public string? Anexo { get; set; }

    public virtual DireccionEmpleado? DireccionEmpleado { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
