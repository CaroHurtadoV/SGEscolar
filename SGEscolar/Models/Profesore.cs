using System;
using System.Collections.Generic;

namespace SGEscolar.Models;

public partial class Profesore
{
    public int ProfesorId { get; set; }

    public string? ProfesorNombre { get; set; }

    public string? ProfesorTelefono { get; set; }

    public string? ProfesorCorreo { get; set; }

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
