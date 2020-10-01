using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebTddBdd.Models;

namespace WebTddBdd.Controllers
{
    public class ClientesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.Clientes = await Cliente.AllAsync();
            return View();
        }

        // método blocante
        public IActionResult Block()
        {
            List<Cliente> clientes = new DBContextWeb().Clientes.ToList();
            ViewBag.Clientes = clientes;
            return View("Index");
        }

        [Route("/dados")]
        public async Task<IActionResult> Dado()
        {
            List<Cliente> clientes = await new DBContextWeb().Clientes.ToListAsync();
            ViewBag.Clientes = clientes;
            return View("Index");
        }
    }
}
