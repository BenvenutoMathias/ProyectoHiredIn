using DataAccess.Base;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Data.Managers
{
    public class EmpresasManager : BaseManager<Empresa>
    {
        public async override Task<List<Empresa>> BuscarListaAsync()
        {
            return await contextoSingleton.Empresas.ToListAsync();
        }

        public async Task<List<Empresa>> BuscarListaAsync(bool incluirRelaciones)
        {
            return await contextoSingleton.Empresas.Include(x => x.Postulantes).ToListAsync();
        }

        public async override Task<Empresa> BuscarUno(int id)
        {
            var respuesta = await contextoSingleton.Empresas.FindAsync(id);

            if(respuesta == null)
            {
                return null;
            }

            return respuesta;
        }

        public async Task<Empresa> BuscarUno(int id, bool incluirRelaciones)
        {
            var respuesta = await contextoSingleton.Empresas.FindAsync(id);

            return respuesta;
        }

        public async override Task<bool> Eliminar(Empresa Empresa)
        {
            contextoSingleton.Entry<Empresa>(Empresa).State = EntityState.Modified;

            var respuesta = await contextoSingleton.SaveChangesAsync() > 0;

            contextoSingleton.Entry<Empresa>(Empresa).State = EntityState.Detached;

            return respuesta;
        }
    }
}