using EspacioNube.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EspacioNube.web.Controllers
{
    public class FormController : Controller
    {
        

       
        public IActionResult Formulario()
        {
            return View();
        }

    [HttpPost]
    public IActionResult DatosContacto(string nombre, string apellido, int telefono, string email, string comentarios)
        {
            /* string nombres = $"Hola {nombre} {apellido} gracias por dejarnos tu contacto tel: ";
            string contacto = $"{telefono} ${email} y tus comentarios ";
            string comentario = $"{comentarios}"; */
           /*  string datos = $"Hola {nombre} {apellido} gracias por dejar tu contacto: {telefono} {email} y tus comentarios {comentarios}"; */
            ViewData["nombres"] = $"{nombre} {apellido}";
            ViewData["contacto"] = $"{telefono} {email} ";
            ViewData["comentario"] = comentarios;

            //return View("DatosContacto");
            return View();
        }


}
}