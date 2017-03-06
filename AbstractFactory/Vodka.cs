namespace Patterns.AbstractFactory
{
	///<summary>
	/// Класс водки. 
	/// </summary>
	public class Vodka : IDreankable
	{
		/// <summary>
		/// Метод распития.
		/// </summary>
		/// <returns>Описание действия</returns>
		public int Drink(int tonus)
		{
			return --tonus;
		}
	}
}
