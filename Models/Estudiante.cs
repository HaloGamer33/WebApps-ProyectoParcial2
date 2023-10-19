using System.ComponentModel.DataAnnotations;
namespace Universidad.Models;

public class Estudiante {
    public int Id { get; set; }
    public string? Apellidos { get; set; }
    public string? Nombres { get; set; }
    [DataType(DataType.Date)]
    public DateTime Fecha_inscripcion { get; set; }
}
