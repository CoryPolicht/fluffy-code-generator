using System.Collections.Generic;

namespace Sphinx.CodeGenerator.Core.Models
{
    public interface IProperty
    {
        IEnumerable<PropertyModel> Properties { get; }
    }
}