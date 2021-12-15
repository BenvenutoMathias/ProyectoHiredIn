using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using EspacioNube.web.Data;

namespace EspacioNube.web.Models
{
    public class Postulante : EntityBase
    {

       /*  [Required]
        public User Usuario { get; set; } */
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Empresa> Empresas { get; set; }

        /* public static implicit operator Postulante(Postulante v)
        {
            throw new NotImplementedException();
        } */
    }
}