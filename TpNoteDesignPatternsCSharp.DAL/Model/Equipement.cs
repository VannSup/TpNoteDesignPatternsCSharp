using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TpNoteDesignPatternsCSharp.DAL.Model
{
    public class Equipement
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeEquipement { get; set; }


        public int PersonnageId { get; set; }
        public Personnage Personnage { get; set; }
    }
}
