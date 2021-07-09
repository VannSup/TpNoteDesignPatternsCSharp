using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TpNoteDesignPatternsCSharp.DAL.Model
{
    public class Personnage
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sexe { get; set; }
        public int Race { get; set; }

        public virtual ICollection<Equipement> Equipements { get; set; }
    }
}
