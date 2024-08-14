using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class VentasDetalle
{
    public int? Idventa { get; set; }

    public int? Idproducto { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public int? Cantidad { get; set; }

    public virtual Producto? IdproductoNavigation { get; set; }

    public virtual Venta? IdventaNavigation { get; set; }
}
