using Microsoft.CodeAnalysis.CSharp;
using Sphinx.CodeGenerator.Core.Models;

namespace Sphinx.CodeGenerator.CSharp
{
    public class ConvertToCSharpSyntax :ISyntaxProvider
    {
        public string ConvertToCode(NameSpaceModel nameSpace)
        {
            var nameSpaceSyntax = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(nameSpace.NameSpaceName));
            return nameSpaceSyntax.ToFullString();
        }
    }

    public interface ISyntaxProvider
    {
        string ConvertToCode(NameSpaceModel nameSpace);
    }
}