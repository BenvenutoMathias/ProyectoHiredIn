using System;
using EspacioNube.web.Data;
using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;


namespace EspacioNube.web.Controllers{

    public class EmpresasController : Controller
    {
        private ApplicationDbContext _context;

        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            return View();
        }

        
        public IActionResult crearEmpresa(string nombre, string rubro, string telefono, string email, string sucursal, string ubicacion){
            
            Empresa NuevaEmpresa = new Empresa(){
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

        public IActionResult EmpresaRegistrada(){
            return View();
        }
        
        public JsonResult ConsultarEmpresas(){
            return Json(_context.Empresas);
        }

    }

}