using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacioNube.web.Models{
public class Postulante
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ID { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Apellido { get; set; }
    [Required]
    public string DNI { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; }

}
}