using Sphinx.CodeGenerator.Core.Models;

namespace Sphinx.CodeGenerator.Core
{
    public static class Domain
    {
        public static NamespaceFactory BuildNamespaceFactory(string referenceId)
        {
            return new NamespaceFactory(referenceId);
        }
    }

    public class NamespaceFactory
    {
    public string ReferenceId { get; }
        public NamespaceFactory(string referenceId)
        {
            ReferenceId = referenceId;
        }

        public NameSpaceModel CreateNamespace(string name)
        {
            return new NameSpaceModel(name);
        }
    }
}