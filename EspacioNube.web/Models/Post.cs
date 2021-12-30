using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using EspacioNube.web.Data;

namespace EspacioNube.web.Models
{
    public class Post : EntityBase
    {

        [Required]
        public string HeaderPost { get; set; }
        
        public string BodyPost { get; set; }
       
        public ICollection<Postulante> Postulantes { get; set; }
        


    }

}