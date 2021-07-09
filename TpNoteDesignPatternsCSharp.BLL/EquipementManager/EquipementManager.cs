using System;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;
using TpNoteDesignPatternsCSharp.DAL.Repositories;

namespace TpNoteDesignPatternsCSharp.BLL
{
    public class EquipementManager : IEquipementManager
    {
        private readonly IEquipementsRepository _equipementsRepository;

        public EquipementManager(IEquipementsRepository equipementsRepository)
        {
            _equipementsRepository = equipementsRepository;
        }

        public Task Add(Equipement equipement)
        {
            return _equipementsRepository.Add(equipement);
        }


        #region Factory Pattern Utilisation
        public IEquipement CreationEquipement(EnumEquipementType typeEquipement, string name)
        {
            return typeEquipement switch
            {
                EnumEquipementType.Arme => Creation(new ConcretFabriqueArme(name)),
                EnumEquipementType.Armure => Creation(new ConcretFabriqueArmure(name)),
                EnumEquipementType.Autre => Creation(new ConcretFabriqueAutre(name)),
                _ => throw new Exception(),
            };
        }

        private IEquipement Creation(Fabrique fabrique)
        {
            return fabrique.OperationDeConstruction();
        }
        #endregion

    }
}
