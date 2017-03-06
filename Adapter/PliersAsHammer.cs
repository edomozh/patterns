namespace Adapter
{

	/// <summary>
	/// Адаптер.
	/// </summary>
	class PliersAsHammer : ICanHammerANail
	{
		private readonly Pliers _pliers;

		public PliersAsHammer(Pliers pliers)
		{
			_pliers = pliers;
		}

		
		public void HammerANail()
		{
			_pliers.Misused();
		}

		public string ToolName { get; } = "Pliers";
	}
}
