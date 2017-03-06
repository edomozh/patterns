namespace AbstractFactory
{
	/// <summary>
	/// Класс абстрактной фабрики человека.
	/// </summary>
	public interface IManFactory
	{
		/// <summary>
		/// Метод создания объекта курева.
		/// </summary>
		/// <returns>Экземпляр ISmokeable</returns>
		ISmokeable CreateShugar();

		/// <summary>
		/// Метод создания объекта напитка.
		/// </summary>
		/// <returns>Экземпляр IDreankable</returns>
		IDreankable CreateDrink();
	}
}
