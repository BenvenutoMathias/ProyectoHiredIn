using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Models;
using EspacioNube.web.Services;
using System.Threading.Tasks;
using EspacioNube.web.Interfaces;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "Empresa, SuperAdmin")]
    public class PostsController : Controller
    {
        private readonly PostsService _postsService;

        public PostsController()
        {
            _postsService = new PostsService();
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Publicaciones = await _postsService.BuscarListaAsync();

            return View();
        }

        public IActionResult CrearPost()
        {
            return View();
        }

        public async Task<IActionResult> Guardar(int id, string titulo, string descripcion)
        {

            var postExistente = _postsService.BuscarListaAsync(id);

            if (postExistente != null)
            {
                Post NuevoPost = new Post()
                {
                    HeaderPost = titulo,
                    BodyPost = descripcion,
                };

                await _postsService.GuardarAsync(NuevoPost);
            }
            else
            {
                Post NuevoPost = new Post()
                {
                    HeaderPost = titulo,
                    BodyPost = descripcion,
                };

                await _postsService.GuardarAsync(NuevoPost);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}