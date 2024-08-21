using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosArgentina;

public partial class Localidade
{
    public int Id { get; set; }

    public int DepartamentosId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Habitantes { get; set; }

    public virtual Departamento Departamentos { get; set; } = null!;
}
