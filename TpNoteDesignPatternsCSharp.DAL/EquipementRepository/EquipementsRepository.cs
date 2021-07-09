using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Contexts;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Repositories
{
    public class EquipementsRepository : IEquipementsRepository
    {
        private readonly IBaseDbContext _baseDbContext;

        public EquipementsRepository(IBaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }

        public Task Add(Equipement equipement)
        {
            _baseDbContext.Equipements.Add(equipement);
            return _baseDbContext.SaveChanges();
        }
    }
}
