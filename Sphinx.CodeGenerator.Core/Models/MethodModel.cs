using System.Collections.Generic;

namespace Sphinx.CodeGenerator.Core.Models
{
    public class MethodModel: IModifier, IClassMember
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public IEnumerable<VariableModel> Variables { get; set; }
        public IEnumerable<StatementModel> Statements { get; set; }
        public EModifier Modifier { get; set; }
        public bool IsAsync { get; set; }
    }
}