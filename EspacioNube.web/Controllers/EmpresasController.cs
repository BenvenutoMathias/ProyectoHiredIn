using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Models;
using EspacioNube.web.Services;
using System.Threading.Tasks;

namespace EspacioNube.web.Controllers
{
    [Authorize(Roles = "Empresa, SuperAdmin")]
    public class EmpresasController : Controller
    {
        private readonly EmpresasService _empresasService;

        public EmpresasController()
        {
            _empresasService = new EmpresasService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearEmpresa()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(int id, string nombre, string rubro, string telefono, string email, string sucursal, string ubicacion)
        {
            var empresaExistente = _empresasService.Manager.BuscarUno(id);

            if (empresaExistente != null)
            {
                Empresa empresa = new Empresa()
                {
                    NombreEmpresa = nombre,
                    Rubro = rubro,
                    Telefono = telefono,
                    Email = email,
                    Sucursal = sucursal,
                    UbicacionSucursal = ubicacion
                };

                await _empresasService.GuardarAsync(empresa);
            }
            else
            {
                Empresa nuevaEmpresa = new Empresa()
                {
                    NombreEmpresa = nombre,
                    Rubro = rubro,
                    Telefono = telefono,
                    Email = email,
                    Sucursal = sucursal,
                    UbicacionSucursal = ubicacion
                };

                await _empresasService.GuardarAsync(nuevaEmpresa);

                return await Task.Run(() => RedirectToAction("ConsultarEmpresas"));
            }

            return await Task.Run(() => RedirectToAction("ConsultarEmpresas"));
        }

        public IActionResult EmpresaRegistrada()
        {
            return View();
        }

        public async Task<IActionResult> ConsultarEmpresas()
        {

            ViewBag.EmpresasList = await _empresasService.BuscarListaAsync();

            return View();
        }

        public async Task<IActionResult> DetalleEmpresa(int id)
        {

            var empresa = await _empresasService.Manager.BuscarUno(id);
            
            if (empresa.Postulantes.Count == 0 || empresa.Postulantes == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }

            ViewBag.empresaDetail = empresa;

            return View();
        }

        public async Task<IActionResult> Editar(int id)
        {
            Empresa editar = await _empresasService.BuscarListaAsync(id);

            if (editar == null)
            {
                return RedirectToAction("ConsultarEmpresas");
            }
            return View(editar);
        }

        public async Task<IActionResult> Actualizar(int id, string nombre, string rubro, string telefono, string email, string sucursal, string ubicacion)
        {
            await Guardar(id, nombre, rubro, telefono, email, sucursal, ubicacion);

            return await Task.Run(() => RedirectToAction("ConsultarEmpresas"));
        }

        public async Task<IActionResult> Eliminar(int Id)
        {
            Empresa Eliminar = await _empresasService.BuscarListaAsync(Id);
            
            if (Eliminar != null)
            {
                await _empresasService.EliminarAsync(Eliminar);
            }

            return RedirectToAction("ConsultarEmpresas");
        }
    }
}