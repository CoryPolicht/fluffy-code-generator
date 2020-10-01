namespace Sphinx.CodeGenerator.Application.UseCases.Boundaries
{
    public interface IOutputPortError<in TUseCaseError> where TUseCaseError : IUseCaseError
    {
        void Error(TUseCaseError error);
    }
}