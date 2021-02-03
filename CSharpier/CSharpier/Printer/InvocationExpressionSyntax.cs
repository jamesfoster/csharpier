using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintInvocationExpressionSyntax(InvocationExpressionSyntax node)
        {
            return Concat(this.Print(node.Expression), this.Print(node.ArgumentList));
        }
    }
}
