namespace DataAccess.Models
{
    public class Postulante : EntityBase
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
    }
}