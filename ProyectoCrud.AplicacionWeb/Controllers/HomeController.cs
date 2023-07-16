using Microsoft.AspNetCore.Mvc;
using ProyectoCrud.AplicacionWeb.Models;
using ProyectoCrud.BLL.Services;
using System.Diagnostics;

namespace ProyectoCrud.AplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactoService _contactoService;

        public HomeController(IContactoService contactoServ)
        {
            _contactoService = contactoServ;
        }

        public IActionResult Index()
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