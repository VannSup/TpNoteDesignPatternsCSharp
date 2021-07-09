using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Contexts
{
    public interface IBaseDbContext
    {
        DbSet<Personnage> Personnages { get; set; }
        DbSet<Equipement> Equipements { get; set; }
        DatabaseFacade Database { get; }

        void AddBasicData();

        Task SaveChanges();
    }

}
