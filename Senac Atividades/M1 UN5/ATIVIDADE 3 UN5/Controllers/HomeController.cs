using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATIVIDADE_3_UN5.Models;

namespace ATIVIDADE_3_UN5.Controllers
{
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

        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Agendamento(Formulario formulario1)
        {
            ListaFormulario.incluir(formulario1);
            return View("Confirmacao");
     
        }

        public IActionResult ListaPedido()
        {
            List<Formulario> pedido = ListaFormulario.Listar();
            return View(pedido);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
