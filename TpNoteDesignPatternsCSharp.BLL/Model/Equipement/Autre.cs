namespace TpNoteDesignPatternsCSharp.BLL.Model
{
    public class Autre : IEquipement
    {
        public Autre(string name)
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
            return EnumEquipementType.Autre;
        }
    }
}
