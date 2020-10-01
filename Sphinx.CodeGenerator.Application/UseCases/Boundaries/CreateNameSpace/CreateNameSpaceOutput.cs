using Sphinx.CodeGenerator.Core.Models;

namespace Sphinx.CodeGenerator.Application.UseCases.Boundaries.CreateNameSpace
{
    public class CreateNameSpaceOutput : IUseCaseOutput
    {
        public NameSpaceModel NameSpaceModel { get; set; }
    }
}