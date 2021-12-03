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

        
        public IActionResult Crear()
        {

            return RedirectToAction("Index");
        }

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
            return View(/* _context.Empresas.ToList() */);
        }

      /*   public IActionResult Editar(int id)
        {
            Empresa editar = _context.Empresas.Find(id);
            if (editar == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }
            return View(editar);
        }
        public IActionResult Actualizar(int id, string nombre)
        {   
            Empresa editar = _context.Empresas.Find(id);
            return View(editar);
            if (editar != null)
            {
                editar.NombreEmpresa = nombre;
                _context.Empresas.Update(editar);
                _context.SaveChanges();
            }
            return RedirectToAction("ConsultarEmpresas");
        } */
    
    }

}