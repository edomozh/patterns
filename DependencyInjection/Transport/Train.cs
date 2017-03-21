namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Поезд.
	/// </summary>
	internal class Train : ITransport
	{
		/// <summary>
		/// Перевезти.
		/// </summary>
		/// <param name="human">Кого.</param>
		/// <param name="city">Куда.</param>
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
			Console.WriteLine("Почухали");
			human.City = city;
		}
	}
}
