namespace Decorator
{
	using System;

	internal static class Program
	{
		static void Main()
		{
			Lady lady1 = new OfficeLady();
			lady1 = new BespectacledLady(lady1); // Девушка в очках.
			Console.WriteLine(lady1.Name);

			Lady lady = new OfficeLady();
			lady = new LadyWithHat(lady);// Офисная девушка.
			Console.WriteLine(lady.Name);

			Lady sportLady = new SportLady(); // Спортивная девушка
			sportLady = new BespectacledLady(sportLady);  // Девушка в очках.
			sportLady = new LadyWithHat(sportLady); // Девушка в шляпе.
			Console.WriteLine(sportLady.Name);

			sportLady = ((LadyWithHat)sportLady).RemoveTheHat();
			Console.WriteLine(sportLady.Name); // Девушка уже без шляпы.

			sportLady = ((BespectacledLady)sportLady).RemoveGlasses();
			Console.WriteLine(sportLady.Name); // Девушка уже и без очков.

			Console.ReadLine();
		}
	}
}
