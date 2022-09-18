using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Base;
using DataAccess.Models;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "Empresa, SuperAdmin")]
    public class PostsController : Controller
    {   
        public PostsController()
        {
        }

        public IActionResult Index()
        {   
            ViewBag.Publicaciones = BaseManager.contextoSingleton.Post.ToList();
            return View();
        }

        public IActionResult CrearPost()
        {  
            return View();
        }

        public IActionResult Guardar(string titulo, string descripcion)
        {  
             Post NuevoPost = new Post()
             {
                HeaderPost = titulo,
                BodyPost = descripcion,
             };

            BaseManager.contextoSingleton.Post.Add(NuevoPost);
            BaseManager.contextoSingleton.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}