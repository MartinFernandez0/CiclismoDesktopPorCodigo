using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosCiclismo;

public partial class TipoProducto
{
    public int Id { get; set; }

    public string? NombreTipoProducto { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
