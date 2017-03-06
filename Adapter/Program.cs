namespace Adapter
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			// Пользователь.
			var user = new User();
			user.Message += Console.WriteLine;

			// Молоток.
			var hammer = new Hammer();
			// Вбиваем гвоздь.
			user.HammerANail(hammer);
			// Молоток сломался
			var pliers = new Pliers();
			// Используем адаптер.
			ICanHammerANail pliersAsANail = new PliersAsHammer(pliers);
			// Забиваем гвоздь плоскогубцами.
			user.HammerANail(pliersAsANail);

			Console.ReadLine();
		}
	}
}
