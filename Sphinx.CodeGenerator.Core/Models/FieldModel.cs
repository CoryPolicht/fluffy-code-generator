namespace Sphinx.CodeGenerator.Core.Models
{
    public class FieldModel : IModifier, IClassMember
    {
        public FieldModel(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public EModifier Modifier { get; set; }
    }
}