using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using DataAccess;
using DataAccess.Base;
using DataAccess.Models;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "UserDefault, SuperAdmin")]
    public class PostulantesController : Controller
    {

        public PostulantesController()
        {
        }

        public IActionResult CrearPostulante()
        {
            ViewBag.EmpresasList = BaseManager.contextoSingleton.Empresas.ToList();

            return View();
        }

        public IActionResult GuardarPostulante(string nombre, string dni, string telefono, string email, DateTime fechaNacimiento, int empresaID)
        {
            Empresa empSel = BaseManager.contextoSingleton.Empresas.Find(empresaID);
            List<Empresa> newList = new List<Empresa>();
            newList.Add(empSel);
            
            Postulante NuevoPostulante = new Postulante()
            {
                Nombre = nombre,
                DNI = dni,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento,
                Empresas = newList,
    
            };

            BaseManager.contextoSingleton.Postulantes.Add(NuevoPostulante);
            BaseManager.contextoSingleton.SaveChanges();

            return RedirectToAction("PostulanteRegistrado");

        }
        public IActionResult PostulanteRegistrado()
        {
            return View();
        }
        
        public IActionResult ConsultarPostulantes()
        {
            ViewBag.PostulantesList = BaseManager.contextoSingleton.Postulantes.ToList();
            
            
            return View();
        }
         public IActionResult Editar(int id)
        {
            Postulante editar = BaseManager.contextoSingleton.Postulantes.Find(id);
            if (editar == null)
            {
                return RedirectToAction("ConsultarPostulantes");
            }
            return View(editar);
        }
        public IActionResult Actualizar(int id, string nombre, string dni, string email, string telefono)
        {   
            Postulante editar = BaseManager.contextoSingleton.Postulantes.Find(id);
            
            if (editar != null)
            {
                 editar.Nombre = nombre;
                 editar.DNI = dni;
                 editar.Email = email;
                 editar.Telefono = telefono;
                BaseManager.contextoSingleton.Postulantes.Update(editar);
                BaseManager.contextoSingleton.SaveChanges();
            }
            return RedirectToAction("ConsultarPostulantes");
        }

        public IActionResult Eliminar(int ID)
        {
            Postulante postulante = BaseManager.contextoSingleton.Postulantes.Find(ID);
            
            if (Eliminar != null)
            {
                BaseManager.contextoSingleton.Postulantes.Remove(postulante);
                BaseManager.contextoSingleton.SaveChanges();
            }

            return RedirectToAction("ConsultarPostulantes");
        }
    }
}