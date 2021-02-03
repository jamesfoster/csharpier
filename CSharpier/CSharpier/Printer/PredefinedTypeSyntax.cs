using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintPredefinedTypeSyntax(PredefinedTypeSyntax node)
        {
            return String(node.Keyword.Text);
        }
    }
}
