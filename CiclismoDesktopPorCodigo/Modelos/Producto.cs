using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.Modelos;

public partial class Producto
{
    public int Id { get; set; }

    public string? NombreProducto { get; set; }

    public string? Color { get; set; }

    public string? Talla { get; set; }

    public string? MF { get; set; }

    public decimal? Precio { get; set; }

    public int? IdtipoProducto { get; set; }

    public string? ClaseProducto { get; set; }

    public int? Idproveedor { get; set; }

    public virtual Compra? Compra { get; set; }

    public virtual TipoProducto? IdtipoProductoNavigation { get; set; }
}
