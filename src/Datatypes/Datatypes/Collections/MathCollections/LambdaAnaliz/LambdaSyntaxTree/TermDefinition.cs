namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree
{
	/// <summary>
	/// Provides an object to represent definitions which the user might input
	/// i.e. "true = \x.\y.x"
	/// This allows something to be written to the console as output
	/// </summary>
	public class TermDefinition : LambdaTerm
	{
		public string Name;
		private bool isFirstDefinition;

		/// <summary>
		/// The constructor adds the terms to the runtime environment
		/// </summary>
		/// <param name="name"></param>
		/// <param name="term"></param>
		public TermDefinition(string name, string term)
		{
			this.Name = name;

			this.isFirstDefinition = true;
			

			//RuntimeEnvironment.Terms.Add(name, term);
		}

		/// <summary>
		/// The critical portion
		/// </summary>
		/// <returns>An appropriate explanation to the user of what they have wrought</returns>
		public override string ToString()
		{
			return (!this.isFirstDefinition ? "re" : "") + "defined " + this.Name;
		}
	}
}
