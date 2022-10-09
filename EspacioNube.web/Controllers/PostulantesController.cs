using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using DataAccess;
using DataAccess.Base;
using DataAccess.Models;
using EspacioNube.web.Services;
using System.Threading.Tasks;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "UserDefault, SuperAdmin")]
    public class PostulantesController : Controller
    {
        private readonly PostulantesService _postulantesService;

        public PostulantesController()
        {
            _postulantesService = new PostulantesService();
        }

        public async Task<IActionResult> CrearPostulante()
        {
            ViewBag.PostulantesList = await _postulantesService.BuscarListaAsync();

            return View();
        }

        public async Task<IActionResult> GuardarPostulante(int id, string nombre, string dni, string telefono, string email, DateTime fechaNacimiento)
        {
            Postulante empSel = await _postulantesService.BuscarListaAsync(id);
            
            Postulante NuevoPostulante = new Postulante()
            {
                Nombre = nombre,
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
            };

            await _postulantesService.GuardarAsync(NuevoPostulante);

            return RedirectToAction("PostulanteRegistrado");

        }
        public IActionResult PostulanteRegistrado()
        {
            return View();
        }
        
        public async Task<IActionResult> ConsultarPostulantes()
        {
            ViewBag.PostulantesList = await _postulantesService.BuscarListaAsync();
            
            return View();
        }
         public async Task<IActionResult> Editar(int id)
        {
            Postulante editar = await _postulantesService.BuscarListaAsync(id);

            if (editar == null)
            {
                return RedirectToAction("ConsultarPostulantes");
            }

            return View(editar);
        }

        public async Task<IActionResult> Actualizar(int id, string nombre, string dni, string email, string telefono)
        {   
            Postulante editar = await _postulantesService.BuscarListaAsync(id);
            
            if (editar != null)
            {
                 editar.Nombre = nombre;
                 editar.DNI = dni;
                 editar.Email = email;
                 editar.Telefono = telefono;

                await _postulantesService.GuardarAsync(editar);
            }
            return RedirectToAction("ConsultarPostulantes");
        }

        public async Task<IActionResult> Eliminar(int id)
        {
            var postulante = await _postulantesService.BuscarListaAsync(id);

            await _postulantesService.EliminarAsync(postulante);

            return RedirectToAction("ConsultarPostulantes");
        }
    }
}