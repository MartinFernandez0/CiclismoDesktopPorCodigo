using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosArgentina;

public partial class Provincia
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
