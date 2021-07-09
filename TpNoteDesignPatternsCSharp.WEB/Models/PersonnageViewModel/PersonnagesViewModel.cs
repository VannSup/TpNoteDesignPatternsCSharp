using System.Collections.Generic;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.WEB.Models
{
    public class PersonnagesViewModel
    {
        public PersonnagesViewModel()
        {
            Personnages = new List<PersonnageViewModel>();
        }

        public PersonnagesViewModel(List<Personnage> personnages)
        {
            Personnages = new List<PersonnageViewModel>();
            personnages.ForEach(personnage => Personnages.Add(new PersonnageViewModel(personnage)));
        }

        public List<PersonnageViewModel> Personnages { get; set; }

    }

    public class PersonnageViewModel
    {
        public PersonnageViewModel(Personnage personnage)
        {
            this.Name = personnage.Name;
            this.Sexe = (EnumSexe)personnage.Sexe;
            this.Race = (EnumRace)personnage.Race;
            this.Personnage = personnage;
        }
        public string Name { get; set; }

        public EnumSexe Sexe { get; set; }

        public EnumRace Race { get; set; }

        public Personnage Personnage { get; set; }
    }
}
