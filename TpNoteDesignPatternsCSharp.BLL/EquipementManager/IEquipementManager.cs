using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.BLL.Model;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.BLL
{
    public interface IEquipementManager
    {
        IEquipement CreationEquipement(EnumEquipementType typeEquipement, string name);

        Task Add(Equipement equipement);

    }
}
