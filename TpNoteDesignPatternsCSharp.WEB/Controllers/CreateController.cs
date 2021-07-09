using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.WEB.Models;

namespace TpNoteDesignPatternsCSharp.WEB.Controllers
{
    public class CreateController : Controller
    {
        private readonly IEquipementManager _equipementManager;
        private readonly IPersonnageManager _personnageManager;

        public CreateController(IEquipementManager equipementManager, IPersonnageManager personnageManager)
        {
            _equipementManager = equipementManager;
            _personnageManager = personnageManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        #region Creation
        [HttpGet]
        public IActionResult AddPersonnage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonnage(AddPersonnageViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            PersonnageBuilderWeb personnageBuilderWeb = new PersonnageBuilderWeb();
            personnageBuilderWeb.BuildSexe((EnumSexe)model.Sexe);
            personnageBuilderWeb.BuildRace((EnumRace)model.Race);
            personnageBuilderWeb.BuildName(model.Name);
            await _personnageManager.Add(personnageBuilderWeb.Personnage);

            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
