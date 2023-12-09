using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGEscolar.Models;

public partial class Alumno
{
    public int AlumnoId { get; set; }
    [Required]
    [Display(Name = "Nombre del alumno")]
    public string? AlumnoNombre { get; set; }
    [Required]
    [Display(Name = "Teléfono del alumno")]
    public string? AlumnoTelefono { get; set; }
    [Required]
    [Display(Name = "Correo del alumno")]
    [EmailAddress]
    public string? AlumnoCorreo { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();
}
