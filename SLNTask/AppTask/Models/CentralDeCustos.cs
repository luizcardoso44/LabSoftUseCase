using System;
using System.Collections.Generic;

namespace AppTask.Models;

public partial class CentralDeCustos
{
    public int Codigo { get; set; }

    public string NomeCentral { get; set; } = null!;

    public decimal? ValorMetaAnual { get; set; }
}
