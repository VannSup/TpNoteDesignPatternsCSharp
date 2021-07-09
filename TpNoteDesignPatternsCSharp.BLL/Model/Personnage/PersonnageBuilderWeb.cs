using System.Collections.Generic;

namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public class PersonnageBuilderWeb : PersonnageBuilder
    {
        public PersonnageBuilderWeb()
        {
            personnage = new PersonnageBLL();
        }

        public override PersonnageBuilder BuildListEquipement(List<IEquipement> equipements)
        {
            personnage.Equipements = new List<IEquipement>();
            return this;
        }
    }
}
