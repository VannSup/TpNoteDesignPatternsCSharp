using System.Collections.Generic;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Repositories
{
    public interface IPersonnageRepository
    {
        List<Personnage> GetAll();
        Task Add(Personnage personnage);

        Personnage GetPersonnageById(int id);
    }
}
