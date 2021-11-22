using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacioNube.web.Models{
public class Empresa : EntityBase
{   
    
    [Required]
    public string NombreEmpresa { get; set; }
    [Required]
    public string Rubro { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Sucursal { get; set; }
    public string UbicacionSucursal { get; set; }
   /*  public Postulante Postulacion { get; set; } */
 
}

}