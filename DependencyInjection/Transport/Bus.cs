namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Автомобиль.
	/// </summary>
	internal class Bus : ITransport
	{
		/// <summary>
		/// Передвигаться.
		/// </summary>
		public void Carry(IHuman human, City city)
		{
			if (human == null)
			{
				throw new ArgumentNullException(nameof(human));
			}
			if (city == null)
			{
				throw new ArgumentNullException(nameof(city));
			}
			Console.WriteLine("Поехали.");
			human.City = city;
		}
	}
}