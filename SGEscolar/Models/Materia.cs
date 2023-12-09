using System;
using System.Collections.Generic;

namespace SGEscolar.Models;

public partial class Materia
{
    public int MateriaId { get; set; }

    public string? MateriaNombre { get; set; }

    public int? ProfesorId { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual Profesore? Profesor { get; set; }
}
