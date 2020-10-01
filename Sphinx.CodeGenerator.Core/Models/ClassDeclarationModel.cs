using System.Collections.Generic;

namespace Sphinx.CodeGenerator.Core.Models
{
    public class ClassDeclarationModel : IModifier, IProperty
    {
        public ClassDeclarationModel(string name)
        {
            Name = name;
        }
        public string Name { get;  }
        public IEnumerable<InterfaceModel> Interfaces { get; set; }
        public string BaseClass { get; private set; }
        public IEnumerable<PropertyModel> Properties { get; set; }
        public IEnumerable<FieldModel> Fields { get; set; }
        public IEnumerable<MethodModel> Methods { get; set; }
        public EModifier Modifier { get; private set; }

        public ClassDeclarationModel AddModifier(EModifier modifier)
        {
            Modifier = modifier;
            return this;
        }

        public ClassDeclarationModel AddBaseClass(string name)
        {
            BaseClass = name;
            return this;
        }
        
    }
}