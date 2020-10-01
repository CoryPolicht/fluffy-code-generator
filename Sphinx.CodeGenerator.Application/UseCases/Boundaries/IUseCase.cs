using System.Threading.Tasks;

namespace Sphinx.CodeGenerator.Application.UseCases.Boundaries
{
    public interface IUseCase<in TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        void Execute(TUseCaseInput input);
        Task ExecuteAsync(TUseCaseInput input);
    }
}