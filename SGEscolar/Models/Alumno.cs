using System;
using System.Collections.Generic;

namespace SGEscolar.Models;

public partial class Alumno
{
    public int AlumnoId { get; set; }

    public string? AlumnoNombre { get; set; }

    public string? AlumnoTelefono { get; set; }

    public string? AlumnoCorreo { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();
}
