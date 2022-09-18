using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Post : EntityBase
    {
        [Required]
        public string HeaderPost { get; set; }
        
        public string BodyPost { get; set; }
       
        public ICollection<Postulante> Postulantes { get; set; }
    }
}