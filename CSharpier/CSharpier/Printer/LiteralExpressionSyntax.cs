using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintLiteralExpressionSyntax(LiteralExpressionSyntax node)
        {
            return String(node.Token.Text);
        }
    }
}
