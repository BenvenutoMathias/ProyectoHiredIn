using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EspacioNube.web.Data;

namespace EspacioNube.web.Models
{
    public class Postulante : EntityBase
    {

        [Required]
        public User Usuario { get; set; }
        [Required]

        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EmpresaID { get; set; }
        public Icollections<Empresa> Empresas { get; set; }

    }
}