using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class DireccionEmpleado
{
    public int Idempleado { get; set; }

    public string? Direccion1 { get; set; }

    public string? Direccion2 { get; set; }

    public string? Ciudad { get; set; }

    public string? Region { get; set; }

    public string? Pais { get; set; }

    public string? Codigopostal { get; set; }

    public virtual Empleado IdempleadoNavigation { get; set; } = null!;
}
