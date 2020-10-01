namespace Sphinx.CodeGenerator.Core.Models
{
    public class PropertyModel: IModifier, IClassMember
    {
        public EModifier Modifier { get; }
        public string Name { get; }
        public string Type { get; }
        public bool UseAutoAccessor { get; }
    }
}