using System.Threading.Tasks;
using Sphinx.CodeGenerator.Application.UseCases.Boundaries;
using Sphinx.CodeGenerator.Core.Models;

namespace Sphinx.CodeGenerator.Application.UseCases
{
    public class CreateCSharpSyntaxUseCase :ICreateCSharpSyntax
    {
        public CreateCSharpSyntaxUseCase()
        {
            
        }

        public void Execute(CreateCSharpSyntaxInput input)
        {
            
        }

        public Task ExecuteAsync(CreateCSharpSyntaxInput input)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ICreateCSharpSyntax : IUseCase<CreateCSharpSyntaxInput>
    {
    }

    public class CreateCSharpSyntaxInput : IUseCaseInput
    {
        public NameSpaceModel NameSpace { get; set; }
    }
}