using System.Collections.Generic;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.BLL
{
    public interface IPersonnageManager
    {
        Personnage GetPersonnage(int id);

        List<Personnage> GetPersonnages();

        Task Add(PersonnageBLL personnage);

    }
}
