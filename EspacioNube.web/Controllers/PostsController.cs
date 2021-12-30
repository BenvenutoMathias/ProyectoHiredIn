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
    public class PostsController : Controller
    {   
        private ApplicationDbContext _context;
        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}