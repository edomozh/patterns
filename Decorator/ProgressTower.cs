namespace Decorator
{
	using System.Drawing;

	/// <summary>
	/// Исследовательская башня, из которой регулируется процесс игры.
	/// </summary>
	class ProgressTower
	{
		protected Tower Tower;

		public ProgressTower()
		{
			Tower  = new Tower(Point.Empty);
		}

		/// <summary>
		/// Обработчик команд к исследовательской башне.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public string[] Command(string command)
		{
			switch (command)
			{
				case "show":
					return new[] { "You can explore new skill, for use it tower with skill name:", "GoWar", "GoPeace" };
				case "GoWar":
					return GoWar();
				case "GoPeace":
					return GoPeace();
				default: return new[] { "Unknown command." };
			}
		}

		// Начать войну.
		private string[] GoWar()
		{
			return new [] { "War started."};

		}

		// Начать мир. :)
		private string[] GoPeace()
		{
			return new[] { "War is over" };
		}
	}
}
