using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstacaoDeRecarga.MVC.Models;
using EstacoesDeRecarga.Aplicacao.Interfaces;

namespace EstacaoDeRecarga.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppEstacaoRecarga _appEstacaoRecarga;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAppEstacaoRecarga appEstacaoRecarga)
        {
            _logger = logger;
            _appEstacaoRecarga = appEstacaoRecarga;
        }

        public IActionResult Index()
        {
            var estacoes = _appEstacaoRecarga.Listar();
            return View(estacoes);
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
