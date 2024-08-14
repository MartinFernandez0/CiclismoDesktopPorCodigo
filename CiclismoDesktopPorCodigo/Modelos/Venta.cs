using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class Venta
{
    public int Id { get; set; }

    public decimal? VentaTotal { get; set; }

    public int? Idcliente { get; set; }

    public int? Idempleado { get; set; }

    public DateTime? FechaPedido { get; set; }

    public DateTime FechaAtencionSolicitada { get; set; }

    public DateTime? FechaDespacho { get; set; }

    public string? EmpresaEnvio { get; set; }

    public bool Enviado { get; set; }

    public string? CasillaPostal { get; set; }

    public bool PagoRecibido { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Empleado? IdempleadoNavigation { get; set; }
}
