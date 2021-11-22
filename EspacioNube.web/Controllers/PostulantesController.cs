using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace EspacioNube.web.Controllers{
    public class PostulantesController : Controller
    {
        private ApplicationDbContext _context;

        public PostulantesController (ApplicationDbContext context){
            _context = context;
        }

        


        public IActionResult CrearPostulante(){

          return View();

            
        }




        public IActionResult GuardarPostulante (string nombre, string apellido, string dni, string telefono, string email, DateTime fechaNacimiento, string genero){

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

        [Authorize]
         public IActionResult ConsultarPostulantes(){
            ViewBag.PostulantesList = _context.Postulantes.ToList();
            return View();
        }
      /*   [Authorize]
        public IActionResult Postular(string nombre){

            Empresa Postulacion = new Empresa (){
                Postulacion = nombre,
            };

            return View();
        } */

    }
}