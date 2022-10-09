using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EspacioNube.web.Interfaces
{
    public interface IPostsService
    {
        Task<List<Post>> BuscarListaAsync();
        Task<List<Post>> BuscarListaAsync(bool incluirRelaciones);
        Task<Post> BuscarListaAsync(int id, bool incluirRelaciones);
        Task<List<Post>> GuardarAsync(Post Post);
        Task<List<Post>> EliminarAsync(Post Post);
    }
}
