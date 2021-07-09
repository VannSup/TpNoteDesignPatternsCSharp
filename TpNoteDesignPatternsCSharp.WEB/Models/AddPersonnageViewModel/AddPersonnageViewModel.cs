using System.ComponentModel.DataAnnotations;

namespace TpNoteDesignPatternsCSharp.WEB.Models
{
    public class AddPersonnageViewModel
    {
        [Required(ErrorMessage = "Choisiser un sexe.")]
        public int Sexe { get; set; }

        [Required(ErrorMessage = "Choisiser une race.")]
        public int Race { get; set; }

        [Required(ErrorMessage = "Choisiser un nom.")]
        public string Name { get; set; }
    }
}
