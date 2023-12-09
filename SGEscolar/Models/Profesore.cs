using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGEscolar.Models;

public partial class Profesore
{
    public int ProfesorId { get; set; }
    [Required]
    [Display(Name = "Nombre completo")]
    public string? ProfesorNombre { get; set; }
    [Required]
    [Display(Name = "Teléfono")]
    public string? ProfesorTelefono { get; set; }
    [Required]
    [Display(Name = "Correo")]
    [EmailAddress]
    public string? ProfesorCorreo { get; set; }

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
