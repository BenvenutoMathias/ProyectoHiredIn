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
    public class EmpresasController : Controller
    {
        private ApplicationDbContext _context;

        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CrearEmpresa()
        {
            return View();
        }


      /*   public IActionResult Crear()
        {

            return RedirectToAction("Index");
        } */
        [HttpPost]
        public IActionResult Guardar(string nombre, string rubro, string telefono, string email, string sucursal, string ubicacion)
        {

            Empresa NuevaEmpresa = new Empresa()
            {
                NombreEmpresa = nombre,
                Rubro = rubro,
                Telefono = telefono,
                Email = email,
                Sucursal = sucursal,
            };

            _context.Empresas.Add(NuevaEmpresa);
            _context.SaveChanges();

            return RedirectToAction("EmpresaRegistrada");
        }



        public IActionResult EmpresaRegistrada()
        {
            return View();
        }

        public IActionResult ConsultarEmpresas()
        {
            ViewBag.EmpresasList = _context.Empresas.Include("Postulantes").ToList();
            return View();
        }



        public IActionResult DetalleEmpresa(int ID)
        {   
           
            var empresa = _context.Empresas.Where(e => e.ID == ID).Include("Postulantes").FirstOrDefault();
            
            if (empresa.Postulantes.Count == 0 || empresa.Postulantes == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }

            ViewBag.empresaDetail = _context.Empresas.Where(e => e.ID == ID).Include("Postulantes");
            return View();
        }

        

        public IActionResult Editar(int id)
        {
            Empresa editar = _context.Empresas.Find(id);
            if (editar == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }
            return View(editar);
        }
        public IActionResult Actualizar(int id, string nombre, string rubro, string telefono, string email)
        {
            Empresa editar = _context.Empresas.Find(id);

            if (editar != null)
            {
                editar.NombreEmpresa = nombre;
                editar.Rubro = rubro;
                editar.Telefono = telefono;
                editar.Email = email;
                _context.Empresas.Update(editar);
                _context.SaveChanges();
            }
            return RedirectToAction("ConsultarEmpresas");
        }

        public IActionResult Eliminar(int ID)
        {
            Empresa Eliminar = _context.Empresas.Find(ID);
            
            if (Eliminar != null)
            {
                _context.Empresas.Remove(Eliminar);
                _context.SaveChanges();
            }
                return RedirectToAction("ConsultarEmpresas");
        }

    }

}