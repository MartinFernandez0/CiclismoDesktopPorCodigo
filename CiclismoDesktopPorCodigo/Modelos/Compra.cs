using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class Compra
{
    public int Idproducto { get; set; }

    public int? PuntoDeReorden { get; set; }

    public int? UnidadesStock { get; set; }

    public int? UnidadesCompra { get; set; }

    public int? CasillaPostal { get; set; }

    public DateTime? FechaDeOrden { get; set; }

    public DateTime? FechaEsperadaDeAtencion { get; set; }

    public bool Recibido { get; set; }

    public bool Pagado { get; set; }

    public virtual Producto IdproductoNavigation { get; set; } = null!;
}
