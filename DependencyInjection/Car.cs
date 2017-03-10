namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Автомобиль.
	/// </summary>
	internal class Car : ITransport
	{
		/// <summary>
		/// Передвигаться.
		/// </summary>
		public void Go(string text)
		{

			Console.WriteLine($"{text} ехать");
		}
	}
}