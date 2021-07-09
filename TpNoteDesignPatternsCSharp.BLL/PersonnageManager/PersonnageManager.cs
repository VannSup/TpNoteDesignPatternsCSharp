using System.Collections.Generic;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;
using TpNoteDesignPatternsCSharp.DAL.Repositories;

namespace TpNoteDesignPatternsCSharp.BLL
{
    public class PersonnageManager : IPersonnageManager
    {
        private readonly IPersonnageRepository _personnageRepository;

        public PersonnageManager(IPersonnageRepository personnageRepository)
        {
            _personnageRepository = personnageRepository;
        }

        public async Task Add(PersonnageBLL personnage)
        {
            await _personnageRepository.Add(personnage.ConvertPersonnage());
        }

        public List<Personnage> GetPersonnages()
        {
            return _personnageRepository.GetAll();
        }

        public Personnage GetPersonnage(int id)
        {
            return _personnageRepository.GetPersonnageById(id);
        }


    }
}
