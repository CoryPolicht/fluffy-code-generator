using Moq;
using Sphinx.CodeGenerator.Application.Tests.TestHelperMethods;
using Sphinx.CodeGenerator.Application.UseCases;
using Sphinx.CodeGenerator.Application.UseCases.Boundaries.CreateNameSpace;
using Xunit;

namespace Sphinx.CodeGenerator.Application.Tests.UseCaseTests
{
    public class CreateNameSpaceTests
    {
        public CreateNameSpaceTests()
        {
            
        }

        [Fact]
        public void CreateNameSpaceTest_OutputSuccess()
        {
            //arrange
            var testInput = GenerateTestData.GenerateTypedTestData<CreateNameSpaceInput>();
            var mockedOutputPort = new Mock<ICreateNameSpaceOutputPort>();
            mockedOutputPort.Setup(x => x.Standard(It.IsAny<CreateNameSpaceOutput>()));
            var useCaseUnderTest = new CreateNameSpaceUseCase(mockedOutputPort.Object);
            
            //act
            useCaseUnderTest.Execute(testInput);
            
            //assert
            mockedOutputPort.Verify(x => x.Standard(It.IsAny<CreateNameSpaceOutput>()));
            
        }

        [Fact]
        public void CreateNameSpaceTest_OutputPortStandardCalledSuccess()
        {
            //arrange
            
            //act
            
            //assert
        }
    }
}