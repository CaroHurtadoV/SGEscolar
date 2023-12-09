using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGEscolar.Models;

public partial class Calificacione
{
    public int CalificacionId { get; set; }
    [Required]
    [Display(Name = "Alumno")]
    public int? AlumnoId { get; set; }
    [Required]
    [Display(Name = "Materia")]
    public int? MateriaId { get; set; }
    [Required]
    [Display(Name = "Calificación del alumno")]
    public double? Calificacion { get; set; }

    public virtual Alumno? Alumno { get; set; }

    public virtual Materia? Materia { get; set; }
}
