namespace Adapter
{

	/// <summary>
	/// Класс к которому адаптируем.
	/// </summary>
	sealed class Hammer : ICanHammerANail
	{
		public void HammerANail()
		{ }

		public string ToolName { get; } = "Hammer";
	}
}
