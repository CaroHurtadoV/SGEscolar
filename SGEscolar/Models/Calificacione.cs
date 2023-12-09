using System;
using System.Collections.Generic;

namespace SGEscolar.Models;

public partial class Calificacione
{
    public int CalificacionId { get; set; }

    public int? AlumnoId { get; set; }

    public int? MateriaId { get; set; }

    public double? Calificacion { get; set; }

    public virtual Alumno? Alumno { get; set; }

    public virtual Materia? Materia { get; set; }
}
