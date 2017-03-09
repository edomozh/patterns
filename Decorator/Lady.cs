namespace Decorator
{

	/// <summary>
	/// Девушка.
	/// </summary>
	internal abstract class Lady
	{
		protected Lady(string name)
		{
			Name = name;
		}
		public string Name { get; private set; }
	}
}