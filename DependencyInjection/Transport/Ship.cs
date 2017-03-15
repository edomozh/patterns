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
			Console.WriteLine("Поплыли.");
			human.City = city;
		}
	}
}
