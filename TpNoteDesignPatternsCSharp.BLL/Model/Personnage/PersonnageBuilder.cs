using System.Collections.Generic;

namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public abstract class PersonnageBuilder
    {
        protected PersonnageBLL personnage;

        public PersonnageBLL Personnage
        {
            get { return personnage; }
        }

        public PersonnageBuilder BuildName(string name)
        {
            personnage.Name = name;
            return this;
        }

        public PersonnageBuilder BuildSexe(EnumSexe sexe)
        {
            personnage.Sexe = sexe;
            return this;
        }

        public PersonnageBuilder BuildRace(EnumRace race)
        {
            personnage.Race = race;
            return this;
        }

        public PersonnageBuilder BuildNewEquipement(IEquipement equipement)
        {
            personnage.Equipements.Add(equipement);
            return this;
        }

        public abstract PersonnageBuilder BuildListEquipement(List<IEquipement> equipements);

    }
}
