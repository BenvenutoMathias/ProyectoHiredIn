using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Empresa : EntityBase
    {
        [Required]
        public string NombreEmpresa { get; set; } = string.Empty;
        public string Rubro { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Sucursal { get; set; } = string.Empty;
        public string UbicacionSucursal { get; set; } = string.Empty;
        public ICollection<Post> Publicaciones { get; set; } = new List<Post>();
        public ICollection<Postulante> Postulantes { get; set; } = new List<Postulante>();
    }
}