using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EspacioNube.web.Models
{
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
        public Postulante Postulantes { get; set; }
        /* public List<Postulante> Postulantes { get; set; } */


    }

}