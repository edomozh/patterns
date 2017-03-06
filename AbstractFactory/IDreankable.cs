namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Класс напитка.
	/// </summary>
	public interface IDreankable
	{
		/// <summary>
		/// Метод распития.
		/// </summary>
		/// <returns>Описание действия</returns>
		int Drink(int tonus);
	}
}
