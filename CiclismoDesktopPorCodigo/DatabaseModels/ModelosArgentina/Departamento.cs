using System;
using System.Collections.Generic;

namespace CiclismoDesktopPorCodigo.DatabaseModels.ModelosArgentina;

public partial class Departamento
{
    public int Id { get; set; }

    public int ProvinciasId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Localidade> Localidades { get; set; } = new List<Localidade>();

    public virtual Provincia Provincias { get; set; } = null!;
}
