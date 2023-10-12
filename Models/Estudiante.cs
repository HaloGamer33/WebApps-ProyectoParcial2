using System.ComponentModel.DataAnnotations;
namespace ProyectoParcial2.Models;

public class Estudiante {
    public int Id { get; set; }
    public string? Apellidos { get; set; }
    public string? Nombres { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de inscipcion")]
    public DateTime Fecha_inscripcion { get; set; }
}
