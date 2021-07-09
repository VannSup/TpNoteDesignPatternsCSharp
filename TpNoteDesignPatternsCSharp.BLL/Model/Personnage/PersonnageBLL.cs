using System.Collections.Generic;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public class PersonnageBLL
    {
        //Unique
        public string Name { get; set; }

        public EnumSexe Sexe { get; set; }

        public EnumRace Race { get; set; }

        public List<IEquipement> Equipements { get; set; }

        public Personnage ConvertPersonnage()
        {
            return new Personnage { Name = this.Name, Sexe = (int)this.Sexe, Race = (int)this.Race };
        }
    }
}
