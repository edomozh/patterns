namespace Mediator
{
	internal class Game : GameObject
	{
		public Game(IManager manager) : base(manager)
		{
			manager.Game = this;
		}

		internal override string Notify(string msg)
		{
			
		}
	}
}