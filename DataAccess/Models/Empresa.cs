using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
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
        public ICollection<Post> Publicaciones { get; set; }
        public ICollection<Postulante> Postulantes { get; set; }
    }
}