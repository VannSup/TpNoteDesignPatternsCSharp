using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;
using TpNoteDesignPatternsCSharp.WEB.Models;

namespace TpNoteDesignPatternsCSharp.WEB.Controllers
{
    public class PersonnageController : Controller
    {
        private readonly IEquipementManager _equipementManager;
        private readonly IPersonnageManager _personnageManager;

        public PersonnageController(IEquipementManager equipementManager, IPersonnageManager personnageManager)
        {
            _equipementManager = equipementManager;
            _personnageManager = personnageManager;

        }

        public ActionResult Index(int id)
        {
            Personnage personnage = _personnageManager.GetPersonnage(id);

            return View(new PersonnageViewModel(personnage));
        }

        #region Creation
        [HttpGet]
        public IActionResult AddEquipement(int id)
        {
            AddEquipementViewModel model = new AddEquipementViewModel { PersonnageId = id };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEquipement(AddEquipementViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            IEquipement equipementFactory = _equipementManager.CreationEquipement((EnumEquipementType)model.Type, model.Name);

            Equipement equipement = new Equipement { Name = equipementFactory.Name(), TypeEquipement = (int)equipementFactory.Type(), PersonnageId = model.PersonnageId };

            await _equipementManager.Add(equipement);

            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
