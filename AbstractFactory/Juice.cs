namespace AbstractFactory
{
	/// <summary>
	/// Класс сока.
	/// </summary>
	public class Juice : IDreankable
	{
		/// <summary>
		/// Метод употребления напитка.
		/// </summary>
		/// <returns>Описание употребления напитка</returns>
		public int Drink(int tonus)
		{
			return ++tonus;
		}
	}
}
