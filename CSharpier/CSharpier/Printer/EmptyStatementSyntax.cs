using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintEmptyStatementSyntax(EmptyStatementSyntax node)
        {
            return String(";");
        }
    }
}
