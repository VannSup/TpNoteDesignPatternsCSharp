namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public class Arme : IEquipement
    {
        public Arme(string name)
        {
            _name = name;
        }

        public string _name { get; set; }

        public string Name()
        {
            return this._name;
        }

        public EnumEquipementType Type()
        {
            return EnumEquipementType.Arme;
        }
    }
}
