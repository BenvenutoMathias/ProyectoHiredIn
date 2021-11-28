using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

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

        [Authorize]
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
        [Authorize]
        public IActionResult ConsultarEmpresas()
        {
            ViewBag.EmpresasList = _context.Empresas.ToList();
            return View();
        }

        /*  public IActionResult AlmacenarPostulantes(){


             List<Postulante> Postulantes = new List<Postulante>(){


             };





             return ;



         } */

    }

}