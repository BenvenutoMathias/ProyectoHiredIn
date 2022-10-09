using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EspacioNube.web.Interfaces
{
    public interface IEmpresasService
    {
        Task<List<Empresa>> BuscarListaAsync();
        Task<List<Empresa>> BuscarListaAsync(bool incluirRelaciones);
        Task<Empresa> BuscarListaAsync(int id, bool incluirRelaciones);
        Task<List<Empresa>> GuardarAsync(Empresa empresa);
        Task<List<Empresa>> EliminarAsync(Empresa empresa);
    }
}
