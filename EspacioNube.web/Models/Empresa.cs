using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using EspacioNube.web.Data;

namespace EspacioNube.web.Models
{
    public class Empresa : EntityBase
    {

        [Required]
        public string NombreEmpresa { get; set; }
        
        public string Rubro { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Sucursal { get; set; }
        public string UbicacionSucursal { get; set; }
        public ICollection<Postulante> Postulantes { get; set; }
        


    }

}