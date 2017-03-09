namespace Decorator
{
	/// <summary> Девушка в очках. </summary>
	class BespectacledLady : LadyDecorator
	{
		public BespectacledLady(Lady p) : base(p.Name + ", в очках", p) { }

		/// <summary>
		/// Снять очки.
		/// </summary>
		public Lady RemoveGlasses()
		{
			return Lady;
		}
	}
}