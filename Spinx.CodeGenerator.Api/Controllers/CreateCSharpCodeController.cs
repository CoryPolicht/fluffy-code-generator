using Microsoft.AspNetCore.Mvc;
using Sphinx.CodeGenerator.Application.UseCases;
using Sphinx.CodeGenerator.Application.UseCases.Boundaries.CreateNameSpace;
using Sphinx.CodeGenerator.CSharp;
using Sphinx.CodeGenerator.Infrastructure;

namespace Spinx.CodeGenerator.Api.Controllers
{
    [Route("CreateFile")]
    public class CreateCSharpCodeController : ControllerBase
    {
        public CreateCSharpCodeController()
        {
            
        }
        [HttpGet]
        public IActionResult CreateCSharpFile()
        {
            //todo create content
            var fileWriter = new FileWriter();
            fileWriter.WriteFileToPath(@"d:/testFiles", "testName.cs", "");
            return Ok();
        }
    }
}