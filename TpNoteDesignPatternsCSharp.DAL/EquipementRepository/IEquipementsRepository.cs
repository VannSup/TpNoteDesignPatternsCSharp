using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Repositories
{
    public interface IEquipementsRepository
    {
        Task Add(Equipement equipement);
    }
}
