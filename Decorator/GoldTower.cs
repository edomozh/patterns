namespace Decorator
{
	using System.Drawing;


	/// <summary>
	/// Золотодобывающая башня. Декоратор для класса башня.
	/// </summary>
	public class GoldTower
	{
		/// <summary>
		/// Башня.
		/// </summary>
		protected Tower Tower;


		public GoldTower()
		{
			Tower = new Tower(Point.Empty);
		}

		/// <summary>
		/// Обработчик команды для золотодобывающей башни.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public string Command(string command)
		{
			if (command == "giveGold")
			{
				return "Catch gold :)";
			}
			return "Unknown command.";
		}
	}
}