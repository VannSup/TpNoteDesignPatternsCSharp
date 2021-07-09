using System;

namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public abstract class Fabrique
    {
        public string Name { get; set; }

        public abstract IEquipement FabricationEquipement();

        public IEquipement OperationDeConstruction()
        {
            IEquipement equipement = FabricationEquipement();
            Console.WriteLine($"Construction d'un equipement de type : {equipement.Type()}, Nomée : {equipement.Name()}");
            return equipement;
        }
    }

    public class ConcretFabriqueArme : Fabrique
    {
        public ConcretFabriqueArme(string name)
        {
            Name = name;
        }

        public override IEquipement FabricationEquipement()
        {
            return new Arme(Name);
        }
    }

    public class ConcretFabriqueArmure : Fabrique
    {
        public ConcretFabriqueArmure(string name)
        {
            Name = name;
        }

        public override IEquipement FabricationEquipement()
        {
            return new Armure(Name);
        }
    }

    public class ConcretFabriqueAutre : Fabrique
    {
        public ConcretFabriqueAutre(string name)
        {
            Name = name;
        }

        public override IEquipement FabricationEquipement()
        {
            return new Autre(Name);
        }
    }
}
