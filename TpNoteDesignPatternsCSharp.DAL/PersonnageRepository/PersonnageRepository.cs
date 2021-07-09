using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Contexts;
using TpNoteDesignPatternsCSharp.DAL.Model;
using TpNoteDesignPatternsCSharp.DAL.Query;

namespace TpNoteDesignPatternsCSharp.DAL.Repositories
{
    public class PersonnageRepository : IPersonnageRepository
    {
        private readonly IBaseDbContext _baseDbContext;

        public PersonnageRepository(IBaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }

        public Task Add(Personnage personnage)
        {
            _baseDbContext.Personnages.Add(personnage);
            return _baseDbContext.SaveChanges();
        }

        public List<Personnage> GetAll()
        {
            return _baseDbContext.Personnages.ToList();
        }

        public Personnage GetPersonnageById(int id)
        {
            return _baseDbContext.Personnages.Include(p => p.Equipements).FilterById(id);
        }

    }
}
