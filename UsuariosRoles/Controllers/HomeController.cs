﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsuariosRoles.Models;
using Microsoft.AspNetCore.Authorization;

namespace UsuariosRoles.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Administrador.Supervisor,Empleado")]
        public IActionResult Ventas()
        {
            return View();
        }
        [Authorize(Roles = "Administrador.Supervisor")]
        public IActionResult Compras()
        {
            return View();
        }
        [Authorize(Roles = "Administrador.Supervisor")]
        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
