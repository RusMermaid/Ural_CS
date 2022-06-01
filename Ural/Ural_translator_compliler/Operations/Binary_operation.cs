//V2.0.5
using System;
using System.Collections.Generic;
using System.Reflection;
using Ural.Ural_translator_compliler;
namespace Ural.Ural_translator_compliler.Operations

{
	public class Binary_operation
	{
		public Token left_node;
		public Token operator_token;
		public Token right_node;
		public List<Token> other_tokens = new List<Token>();

		public Binary_operation(Token _left_node, Token _operator_token, Token _right_node, List<Token> args = null)
		{
			this.left_node = _left_node;
			this.operator_token = _operator_token;
			this.right_node = _right_node;
			this.other_tokens.AddRange(args);

		}
	}
}
