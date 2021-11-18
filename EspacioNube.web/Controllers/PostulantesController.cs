using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.web.Controllers{
    public class PostulantesController : Controller
    {
        private ApplicationDbContext _context;
        public PostulantesController (ApplicationDbContext context){
            _context = context;
        }
        public IActionResult Index(){
            return View();
        }

        public IActionResult crearPostulante(string nombre, string apellido, string dni, string telefono, string email, DateTime fechaNacimiento, string genero){

            Postulante NuevoPostulante = new Postulante(){
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
                Genero = genero,

            };

            _context.Postulantes.Add(NuevoPostulante);
            _context.SaveChanges();

            return RedirectToAction("PostulanteRegistrado");
        }

        public IActionResult PostulanteRegistrado(){
            return View();
        }

         public JsonResult ConsultarPostulantes(){
            return Json(_context.Postulantes);
        }

    }
}