using DataAccess.Base;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Data.Managers
{
    public class PostulantesManager : BaseManager<Postulante>
    {
        public async override Task<List<Postulante>> BuscarListaAsync()
        {
            return await contextoSingleton.Postulantes.ToListAsync();
        }

        //public async Task<List<Postulante>> BuscarListaAsync(bool incluirRelaciones)
        //{
        //    //return await contextoSingleton.Postulantes.Include(x => x.Posts).ToListAsync();
        //}

        public async override Task<Postulante> BuscarUno(int id)
        {
            var respuesta = await contextoSingleton.Postulantes.FindAsync(id);

            if (respuesta == null)
            {
                return null;
            }

            return respuesta;
        }

        public async override Task<bool> Eliminar(Postulante Postulante)
        {
            contextoSingleton.Entry<Postulante>(Postulante).State = EntityState.Modified;

            var respuesta = await contextoSingleton.SaveChangesAsync() > 0;

            contextoSingleton.Entry<Postulante>(Postulante).State = EntityState.Detached;

            return respuesta;
        }
    }
}
