namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Фабрика создания алкоголика.
	/// </summary>
	public class AlcoholicFactory : IManFactory
	{
		/// <summary>
		/// Метод создания экземпляра класса курения.
		/// </summary>
		/// <returns>Экземпляр класса курева.</returns>
		public ISmokeable CreateShugar()
		{
			return new Vape();
		}

		/// <summary>
		/// Метод создания экземпляра класса напитка.
		/// </summary>
		/// <returns>Экземпляр класса водки.</returns>
		public IDreankable CreateDrink()
		{
			return new Vodka();
		}
	}
}
