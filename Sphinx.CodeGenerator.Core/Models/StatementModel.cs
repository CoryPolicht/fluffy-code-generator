namespace Sphinx.CodeGenerator.Core.Models
{
    public class StatementModel
    {
        public string Statement { get; }

        public StatementModel(string statement)
        {
            Statement = statement;
        }
    }
}