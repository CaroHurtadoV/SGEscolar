using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGEscolar.Models;

public partial class Materia
{
    public int MateriaId { get; set; }
    [Required]
    [Display(Name = "Nombre de la materia")]
    public string? MateriaNombre { get; set; }
    [Required]
    [Display(Name = "Profesor que imparte la materia")]
    public int? ProfesorId { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual Profesore? Profesor { get; set; }
}
