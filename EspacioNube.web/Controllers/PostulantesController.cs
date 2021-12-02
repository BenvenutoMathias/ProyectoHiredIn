using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace EspacioNube.web.Controllers
{
    public class PostulantesController : Controller
    {
        private ApplicationDbContext _context;

        public PostulantesController(ApplicationDbContext context)
        {
            _context = context;
        }



        /* [Authorize] */
        public IActionResult CrearPostulante()
        {
            ViewBag.EmpresasList = _context.Empresas.ToList();

            return View();


        }


        public IActionResult GuardarPostulante(string nombre, string dni, string telefono, string email, DateTime fechaNacimiento, int empresaID)
        {
            Empresa empSel = _context.Empresas.Find(empresaID);
            List<Empresa> newList = new List<Empresa>();
            newList.Add(empSel);
            
            Postulante NuevoPostulante = new Postulante()
            {
                Nombre = nombre,
                /*  Apellido = apellido, */ 
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
                Empresas = newList,
               /*  Genero = genero, */

            };

            _context.Postulantes.Add(NuevoPostulante);
            _context.SaveChanges();

            return RedirectToAction("PostulanteRegistrado");

        }

        


        public IActionResult PostulanteRegistrado()
        {
            return View();
        }

        
        public IActionResult ConsultarPostulantes()
        {
            ViewBag.PostulantesList = _context.Postulantes.ToList();
            
            
            return View();
        }
      

        

    }
}