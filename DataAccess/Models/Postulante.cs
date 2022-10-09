namespace DataAccess.Models
{
    public class Postulante : EntityBase
    {
        public string Nombre { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
    }
}