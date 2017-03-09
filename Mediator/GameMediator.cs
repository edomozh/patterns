namespace Mediator
{
	class GameMediator : IMediator
	{
		public GameObject User { get; set; }
		public GameObject Menu { get; set; }
		public GameObject Game { get; set; }


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