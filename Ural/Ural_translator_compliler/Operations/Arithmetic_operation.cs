using System;
using Ural.Ural_translator_compliler;
namespace Ural.Ural_translator_compliler.Operations
{
    public class Arithmetic_operation : Binary_operation
    {
        public Arithmetic_operation(Token _left_node, Token _operator_token, Token _right_node) : base(_left_node, _operator_token, _right_node)
        {

        }
    }
}
