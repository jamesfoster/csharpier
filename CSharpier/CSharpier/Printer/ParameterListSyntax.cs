using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintParameterListSyntax(ParameterListSyntax node)
        {
            if (node.Parameters.Count == 0) {
                return String("()");
            }
            return Group(Concat(String("("), Indent(Concat(SoftLine, this.PrintCommaList(node.Parameters.Select(this.Print)))), String(")")));
        }
    }
}
