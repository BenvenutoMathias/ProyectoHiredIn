using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace EspacioNube.web.Controllers
{
    public class PostulantesController : Controller
    {
        private ApplicationDbContext _context;

        public PostulantesController(ApplicationDbContext context)
        {
            _context = context;
        }



        [Authorize]
        public IActionResult CrearPostulante()
        {
            ViewBag.EmpresasList = _context.Empresas.ToList();

            return View();


        }




        public IActionResult GuardarPostulante(string dni, string telefono, string email, DateTime fechaNacimiento, string empresaID)
        {

            Postulante NuevoPostulante = new Postulante()
            {
                /*  Nombre = nombre,
                 Apellido = apellido, */
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
               /*  Genero = genero, */

            };

            _context.Postulantes.Add(NuevoPostulante);
            _context.SaveChanges();

            return RedirectToAction("PostulanteRegistrado");

        }

        /* public IActionResult PostularPostulante(Empresa nombre)
        {
            
            
        
            Empresa Postulacion = new Empresa()
            {
                Postulacion = nombre,
            };

            return RedirectToAction("PostulacionExitosa");
        } */



        public IActionResult PostulanteRegistrado()
        {
            return View();
        }

        [Authorize]
        public IActionResult ConsultarPostulantes()
        {
            ViewBag.PostulantesList = _context.Postulantes.ToList();
            return View();
        }
        [Authorize]

        public IActionResult PostulacionExitosa()
        {
            return View();
        }

    }
}