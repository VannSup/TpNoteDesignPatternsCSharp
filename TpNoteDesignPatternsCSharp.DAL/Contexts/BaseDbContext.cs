using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Contexts
{
    public partial class BaseDbContext : DbContext, IBaseDbContext
    {
        public virtual DbSet<Personnage> Personnages { get; set; }
        public virtual DbSet<Equipement> Equipements { get; set; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Equipement>()
                .HasOne<Personnage>(equipements => equipements.Personnage)
                .WithMany(perso => perso.Equipements)
                .HasForeignKey(equipements => equipements.PersonnageId);

        }

        public void AddBasicData()
        {
            if (Equipements.Count() == 0 && Personnages.Count() == 0)
            {

                Personnage personnage = new Personnage() { Name = "Thor", Sexe = 0, Race = 0 };

                Personnages.Add(personnage);
                base.SaveChanges();

                Equipement equipement = new Equipement() { Name = "Mjollnir", TypeEquipement = 0, PersonnageId = personnage.Id };

                Equipements.Add(equipement);
                base.SaveChanges();
            }
        }

        public new async Task SaveChanges()
        {
            await base.SaveChangesAsync();
        }
    }
}
