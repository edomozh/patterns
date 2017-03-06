namespace AbstractFactory
{
	/// <summary>
	/// Интерфейс чего то курибельного.
	/// </summary>
	public interface ISmokeable
	{
		/// <summary>
		/// Метод курения.
		/// </summary>
		/// <returns>Измененный тонус.</returns>
		int Smoke(int tonus);
	}
}
