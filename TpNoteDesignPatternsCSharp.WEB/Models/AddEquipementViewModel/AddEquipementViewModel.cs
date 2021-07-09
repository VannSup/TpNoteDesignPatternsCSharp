using System.ComponentModel.DataAnnotations;

namespace TpNoteDesignPatternsCSharp.WEB.Models
{
    public class AddEquipementViewModel
    {
        [Required(ErrorMessage = "Choisiser un sexe.")]
        public int Type { get; set; }

        [Required(ErrorMessage = "Choisiser une race.")]
        public int PersonnageId { get; set; }

        [Required(ErrorMessage = "Choisiser un nom.")]
        public string Name { get; set; }
    }
}
