namespace Decorator
{
	using System;
	using System.Drawing;

	/// <summary>
	/// Военная башня.
	/// </summary>
	public class WarTower
	{
		protected Tower Tower;


		public WarTower()
		{
			Tower = new Tower(Point.Empty);
		}


		public string Command(string command)
		{
			switch (command)
			{
				case "upgrade":
					return Upgrade();
				case "Attak":
					return Attak();
				default: return "Unknown command.";
			}
		}

		private string Upgrade()
		{
			return "WarTower upgraded.";
		}

		private string Attak()
		{
			return $"Ohhh, i am very glad. Attaaaak!!! \r\n Attack from a position {Tower.Location}";
		}
	}
}