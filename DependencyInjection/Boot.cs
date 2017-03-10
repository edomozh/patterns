namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Лодка.
	/// </summary>
	internal class Boot : ITransport
	{
		/// <summary>
		/// Передвигаться.
		/// </summary>
		/// <param name="text"></param>
		public void Go(string text)
		{
			Console.WriteLine($"{text} плыть");
		}
	}
}
