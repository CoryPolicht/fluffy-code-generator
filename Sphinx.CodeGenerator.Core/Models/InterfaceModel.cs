using System.Collections;
using System.Collections.Generic;

namespace Sphinx.CodeGenerator.Core.Models
{
    public class InterfaceModel: IProperty
    {
        public string Name { get; set; }
        public IEnumerable<PropertyModel> Properties { get; set; }
        public IEnumerable<MethodModel> Methods { get; }
    }
}