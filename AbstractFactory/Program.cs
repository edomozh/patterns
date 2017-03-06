namespace Patterns.AbstractFactory
{
	using System;
	class Program
	{
		public static void Main()
		{
			try
			{
				var man = new Man(new AlcoholicFactory(), 100);
				Console.WriteLine($"Выпьем и покурим. {man.Drink()}, {man.Smoke()}");
				Console.WriteLine($" И я в тонусе {man.Tonus}.");

				var man2 = new Man(new AddictFactory(), 100);
				Console.WriteLine($"Выпьем и покурим. {man2.Drink()}, {man2.Smoke()}");
				Console.WriteLine($" И я в тонусе {man2.Tonus}.");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			Console.ReadKey();
		}
	}
}
