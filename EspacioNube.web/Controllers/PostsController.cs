using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "Empresa, SuperAdmin")]
    public class PostsController : Controller
    {   
        private ApplicationDbContext _context;
        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            ViewBag.Publicaciones = _context.Post.ToList();
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

            /* List<Post> Publicaciones = new List<Post>();
            Publicaciones.Add(NuevoPost); */
            _context.Post.Add(NuevoPost);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}