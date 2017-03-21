namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Лодка.
	/// </summary>
	internal class Ship : ITransport
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
			Console.WriteLine("Поплыли.");
			human.City = city;
		}
	}
}
