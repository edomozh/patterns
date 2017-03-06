namespace AbstractFactory
{
	/// <summary>
	/// Фабрика создания наркомана.
	/// </summary>
	public class AddictFactory : IManFactory
	{
		/// <summary>
		/// Метод создания экземпляра класса курева.
		/// </summary>
		/// <returns>Экземпляр интерфейса курябельного объекта.</returns>
		public ISmokeable CreateShugar()
		{
			return new Shugar();
		}

		/// <summary>
		/// Метод создания экземпляра класса напитка.
		/// </summary>
		/// <returns>Выпиваемый объект.</returns>
		public IDreankable CreateDrink()
		{
			return new Juice();
		}
	}
}
