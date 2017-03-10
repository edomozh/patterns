namespace DependencyInjection
{
	using System;

	internal static class Program
	{
		public static void Main()
		{
			var book = new Traveler("Вася", new Car());
			book.Travel();
			book.Transport = new Boot();
			book.Travel();

			Console.ReadLine();
		}
	}
}
