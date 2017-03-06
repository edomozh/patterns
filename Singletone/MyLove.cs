namespace Patterns.Singleton
{
	using System.Data.Common;
	using System.Drawing;

	/// <summary>
	/// класс премьер-министра.
	/// </summary>
	public class MyGirl
	{
		public Point Location { get; private set; }

		private static readonly MyGirl _instance = new MyGirl(Point.Empty);

		private MyGirl(Point location)
		{
			Location = location;
		}

		public static MyGirl Instance => _instance;

		/// <summary>
		/// Метод звонка.
		/// </summary>
		/// <returns></returns>
		public string Call(string question)
		{
			switch (question)
			{
				case "": return "";
				case "Where are u?":
					return $"Я в {Location}";
				default: return "";
			}
		}
	}
}
