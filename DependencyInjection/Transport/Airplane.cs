namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Самолет.
	/// </summary>
	internal class Airplane : ITransport
	{
		/// <summary>
		/// Перевезти.
		/// </summary>
		/// <param name="human">Человек.</param>
		/// <param name="city">Город.</param>
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
			Console.WriteLine("Полетели");
			human.City = city;
		}
	}
}
