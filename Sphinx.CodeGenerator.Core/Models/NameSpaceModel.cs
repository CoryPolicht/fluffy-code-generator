using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sphinx.CodeGenerator.Core.Models
{
    public class NameSpaceModel
    {
        public NameSpaceModel(string name)
        {
            NameSpaceName = name;
        }
        public IEnumerable<string> UsingStatements { get; private set; }
        public string NameSpaceName { get; }
        public IEnumerable<ClassDeclarationModel> ClassDeclarations { get; set; }

        public NameSpaceModel AddUsingStatement(string statement)
        {
            if (UsingStatements == null)
            {
                UsingStatements = new List<string>();
            }
            UsingStatements.Append(statement);
            return this;
        }

        public ClassDeclarationModel AddNewClassDeclaration(string name)
        {
            var newClass = new ClassDeclarationModel(name);
            ClassDeclarations.Append(newClass);
            return newClass;
        }
    }
}