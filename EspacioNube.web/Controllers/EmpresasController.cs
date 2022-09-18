using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using DataAccess.Base;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "Empresa, SuperAdmin")]
    public class EmpresasController : Controller
    {

        public EmpresasController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearEmpresa()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Guardar(string nombre, string rubro, string telefono, string email, string sucursal, string ubicacion)
        {
            var BaseManager = new BaseManager();

            Empresa NuevaEmpresa = new Empresa()
            {
                NombreEmpresa = nombre,
                Rubro = rubro,
                Telefono = telefono,
                Email = email,
                Sucursal = sucursal,
            };

            BaseManager.contextoSingleton.Empresas.Add(NuevaEmpresa);
            BaseManager.contextoSingleton.SaveChangesAsync();

            return RedirectToAction("EmpresaRegistrada");
        }



        public IActionResult EmpresaRegistrada()
        {
            return View();
        }

        public IActionResult ConsultarEmpresas()
        {
            var BaseManager = new BaseManager();

            ViewBag.EmpresasList = BaseManager.contextoSingleton.Empresas.Include("Postulantes").ToList();

            return View();
        }



        public IActionResult DetalleEmpresa(int ID)
        {

            var BaseManager = new BaseManager();

            var empresa = BaseManager.contextoSingleton.Empresas.Where(e => e.ID == ID).Include("Postulantes").FirstOrDefault();
            
            if (empresa.Postulantes.Count == 0 || empresa.Postulantes == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }

            ViewBag.empresaDetail = BaseManager.contextoSingleton.Empresas.Where(e => e.ID == ID).Include("Postulantes");

            return View();
        }

        

        public IActionResult Editar(int id)
        {
            var BaseManager = new BaseManager();

            Empresa editar = BaseManager.contextoSingleton.Empresas.Find(id);

            if (editar == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }
            return View(editar);
        }

        public IActionResult Actualizar(int id, string nombre, string rubro, string telefono, string email)
        {
            var BaseManager = new BaseManager();

            Empresa editar = BaseManager.contextoSingleton.Empresas.Find(id);

            if (editar != null)
            {
                editar.NombreEmpresa = nombre;
                editar.Rubro = rubro;
                editar.Telefono = telefono;
                editar.Email = email;

                BaseManager.contextoSingleton.Empresas.Update(editar);
                BaseManager.contextoSingleton.SaveChangesAsync();
            }
            return RedirectToAction("ConsultarEmpresas");
        }

        public IActionResult Eliminar(int ID)
        {
            var BaseManager = new BaseManager();

            Empresa Eliminar = BaseManager.contextoSingleton.Empresas.Find(ID);
            
            if (Eliminar != null)
            {
                BaseManager.contextoSingleton.Empresas.Remove(Eliminar);
                BaseManager.contextoSingleton.SaveChangesAsync();
            }
                return RedirectToAction("ConsultarEmpresas");
        }

    }

}