namespace Decorator
{
	using System.Drawing;

	public class Tower
	{
		/// <summary>
		/// Позиция башни.
		/// </summary>
		public Point Location { get; private set; }

		/// <summary>
		/// Устанавливается позиция башни.
		/// </summary>
		/// <param name="location"></param>
		public Tower(Point location)
		{
			Location = location;
		}
	}
}
