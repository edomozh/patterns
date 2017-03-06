namespace Mediator
{
	/// <summary>
	/// Класс медиатор.
	/// </summary>
	class GameManager : IManager
	{
		public User User { get; set; }
		public Game Game { get; set; }
		public Menu Menu { get; set; }

		public string Send(GameObject sender, string msg)
		{
			if (User == sender && Menu.Active)
				return Menu.Notify(msg);
			if (User == sender && !Menu.Active)
				return Game.Notify(msg);
			if (Menu == sender)
				return Game.Notify(msg);
			if (Game == sender)
				return Menu.Notify(msg);
			return "What?";
		}
	}
}
