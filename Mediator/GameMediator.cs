namespace Mediator
{
	/// <summary>
	/// Посредник контролирующий связи игровых объектов.
	/// </summary>
	class GameMediator : IMediator
	{
		/// <summary>
		/// Пользователь.
		/// </summary>
		public GameObject User { get; set; }

		/// <summary>
		/// Меню.
		/// </summary>
		public GameObject Menu { get; set; }

		/// <summary>
		/// Игра.
		/// </summary>
		public GameObject Game { get; set; }

		/// <summary>
		/// Перенаправление сообщений от разных игровых объектов.
		/// </summary>
		public void Send(string msg, GameObject gameObject)
		{
			if (User == gameObject)
			{
				Menu.Notify(msg);
			}
			else if (Menu == gameObject)
			{
				Game.Notify(msg);
			}
			else if (Game == gameObject)
			{
				User.Notify(msg);
			}
		}
	}
}