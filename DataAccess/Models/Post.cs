using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Post : EntityBase
    {
        [Required]
        public string HeaderPost { get; set; } = string.Empty;
        public string BodyPost { get; set; } = string.Empty;
        public ICollection<Postulante> Postulantes { get; set; } = new List<Postulante>(); 
    }
}