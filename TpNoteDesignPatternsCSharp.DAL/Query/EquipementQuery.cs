using System.Linq;
using TpNoteDesignPatternsCSharp.DAL.Model;

namespace TpNoteDesignPatternsCSharp.DAL.Query
{
    public static class EquipementQuery
    {
        public static Equipement FilterById(this IQueryable<Equipement> equipements, int Id)
        {
            return equipements.Single(equipement => equipement.Id == Id);
        }

        public static IQueryable<Equipement> FilterByName(this IQueryable<Equipement> equipements, string name)
        {
            if (!string.IsNullOrEmpty(name))
                return equipements.Where(equipement => equipement.Name.Contains(name));
            return equipements;
        }

        public static IQueryable<Equipement> FilterByType(this IQueryable<Equipement> equipements, int? type = null)
        {
            if (type != null)
                return equipements.Where(equipement => equipement.TypeEquipement == type);
            return equipements;
        }

        public static IQueryable<Equipement> FilterByPersonnageId(this IQueryable<Equipement> equipements, int? Id = null)
        {
            if (Id != null)
                return equipements.Where(equipement => equipement.PersonnageId == Id);
            return equipements;
        }
    }
}
