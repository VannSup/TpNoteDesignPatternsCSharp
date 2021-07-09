using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TpNoteDesignPatternsCSharp.BLL;
using TpNoteDesignPatternsCSharp.WEB.Models;

namespace TpNoteDesignPatternsCSharp.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEquipementManager _equipementManager;
        private readonly IPersonnageManager _personnageManager;

        public HomeController(IEquipementManager equipementManager, IPersonnageManager personnageManager)
        {
            _equipementManager = equipementManager;
            _personnageManager = personnageManager;
        }

        public IActionResult Index()
        {
            PersonnagesViewModel personnageViewModel = new PersonnagesViewModel(_personnageManager.GetPersonnages());
            return View(personnageViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
