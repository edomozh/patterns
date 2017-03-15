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
			Console.WriteLine("Поехали.");
			human.City = city;
		}
	}
}