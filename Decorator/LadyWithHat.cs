namespace Decorator
{
	/// <summary>
	/// Девушка в шляпе.
	/// </summary>
	internal class LadyWithHat : LadyDecorator
	{
		public LadyWithHat(Lady p): base(p.Name + ", в шляпе", p) { }

		/// <summary>
		/// Снять шляпу.
		/// </summary>
		public Lady RemoveTheHat()
		{
			return Lady;
		}
	}
}