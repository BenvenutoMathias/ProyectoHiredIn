using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace EspacioNube.web.Controllers{
    public class UsuariosController : Controller
    {
        private ApplicationDbContext _context;

        public UsuariosController (ApplicationDbContext context){
            _context = context;
        }

        


        public IActionResult CrearUsuario(){

          return View();

            
        }




        public IActionResult GuardarUsuario (string nombre, string apellido, string dni, string telefono, string email, DateTime fechaNacimiento, string genero){

              Usuario NuevoUsuario = new Usuario(){
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
                Genero = genero,

            };

            _context.Usuarios.Add(NuevoUsuario);
            _context.SaveChanges();

            return RedirectToAction("UsuarioRegistrado");

        }




        public IActionResult UsuarioRegistrado(){
            return View();
        }

        [Authorize]
         public IActionResult ConsultarUsuarios(){
            ViewBag.UsuariosList = _context.Usuarios.ToList();
            return View();
        }
        [Authorize]
        public IActionResult PostularUsuario(Usuario nombre){

            Empresa Postulacion = new Empresa (){
                Postulacion = nombre,
            };

            return RedirectToAction("PostulacionExitosa");
        }

        public IActionResult PostulacionExitosa (){
            return View();
        }

    }
}