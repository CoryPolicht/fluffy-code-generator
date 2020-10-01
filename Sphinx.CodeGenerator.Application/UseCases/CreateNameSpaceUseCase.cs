using System;
using System.Threading.Tasks;
using Sphinx.CodeGenerator.Application.UseCases.Boundaries.CreateNameSpace;
using Sphinx.CodeGenerator.Core;

namespace Sphinx.CodeGenerator.Application.UseCases
{
    public class CreateNameSpaceUseCase : ICreateNameSpace
    {
        private readonly NamespaceFactory _nameSpaceFactory = Domain.BuildNamespaceFactory(new Guid().ToString());

        public CreateNameSpaceUseCase(ICreateNameSpaceOutputPort outputPort)
        {
            OutputPort = outputPort;
        }
        public ICreateNameSpaceOutputPort OutputPort { get; private set; }
        public void Execute(CreateNameSpaceInput input)
        {
            var nameSpace = _nameSpaceFactory.CreateNamespace(input.Name);
            var output = new CreateNameSpaceOutput(){NameSpaceModel = nameSpace};
            OutputPort.Standard(output);
        }

        public Task ExecuteAsync(CreateNameSpaceInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}