namespace Patterns.AbstractFactory
{
	///<summary>
	/// Класс курева. 
	/// </summary>
	public class Shugar : ISmokeable
	{
		/// <summary>
		/// Метод курения.
		/// </summary>
		/// <returns>Измененный тонус.</returns>
		public int Smoke(int tonus)
		{
			return --tonus;
		}
	}
}
