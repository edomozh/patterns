namespace AbstractFactory
{
	using System;

	/// <summary>
	/// Класс человека.
	/// </summary>
	public class Man
	{
		// Жизненный тонус.
		public int Tonus { get; private set; }

		// Напиток.
		private readonly IDreankable _liquid;

		// Курево.
		private readonly ISmokeable _tobacco;

		/// <summary>
		/// Конструктор, присваивающий значения полям напитков, курева и тонуса.
		/// </summary>
		/// <param name="manFactory">Экземпляр дочерного класса IManFactory</param>
		/// <param name="tonus">Жизненная сила.</param>
		public Man(IManFactory manFactory, int tonus)
		{
			
			if (manFactory == null)
			{
				throw new ArgumentNullException(nameof(manFactory));
			}

			_liquid = manFactory.CreateDrink();
			_tobacco = manFactory.CreateSmokableThing();
			Tonus = tonus;
		}

		/// <summary>
		/// Метод употребления напитка.
		/// </summary>
		public int Drink()
		{
			return Tonus = _liquid.Drink(Tonus);
		}

		/// <summary>
		/// Метод курения.
		/// </summary>
		/// <returns>Тонус человека.</returns>
		public int Smoke()
		{
			return Tonus = _tobacco.Smoke(Tonus);
		}
	}
}
