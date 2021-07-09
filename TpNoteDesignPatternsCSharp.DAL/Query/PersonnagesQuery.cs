using System.Linq;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Query
{
    public static class PersonnagesQuery
    {
        public static Personnage FilterById(this IQueryable<Personnage> personnages, int Id)
        {
            return personnages.Single(personnage => personnage.Id == Id);
        }

        public static IQueryable<Personnage> FilterByName(this IQueryable<Personnage> personnages, string name)
        {
            if (!string.IsNullOrEmpty(name))
                return personnages.Where(personnage => personnage.Name.Contains(name));
            return personnages;
        }

        public static IQueryable<Personnage> FilterBySexe(this IQueryable<Personnage> personnages, int? sexe = null)
        {
            if (sexe != null)
                return personnages.Where(personnage => personnage.Sexe == sexe);
            return personnages;
        }

        public static IQueryable<Personnage> FilterByRace(this IQueryable<Personnage> personnages, int? race = null)
        {
            if (race != null)
                return personnages.Where(personnage => personnage.Race == race);
            return personnages;
        }

    }
}
