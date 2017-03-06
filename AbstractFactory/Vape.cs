namespace AbstractFactory
{
	/// <summary>
	/// Вэйп.
	/// </summary>
	internal class Vape : ISmokeable
	{
		/// <summary>
		/// Метод курения.
		/// </summary>
		/// <returns>Измененный тонус</returns>
		public int Smoke(int tonus)
		{
			return tonus;
		}
	}
}
