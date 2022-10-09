using DataAccess.Base;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Data.Managers
{
    public class PostsManager : BaseManager<Post>
    {
        public async override Task<List<Post>> BuscarListaAsync()
        {
            return await contextoSingleton.Posts.ToListAsync();
        }

        public async Task<List<Post>> BuscarListaAsync(bool incluirRelaciones)
        {
            return await contextoSingleton.Posts.Include(x => x.Postulantes).ToListAsync();
        }

        public async override Task<Post> BuscarUno(int id)
        {
            var respuesta = await contextoSingleton.Posts.FindAsync(id);

            if (respuesta == null)
            {
                return null;
            }

            return respuesta;
        }

        public async override Task<bool> Eliminar(Post Post)
        {
            contextoSingleton.Entry<Post>(Post).State = EntityState.Modified;

            var respuesta = await contextoSingleton.SaveChangesAsync() > 0;

            contextoSingleton.Entry<Post>(Post).State = EntityState.Detached;

            return respuesta;
        }
    }
}
