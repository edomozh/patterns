namespace Mediator
{
	using System;

	class Game : GameObject
	{
		public Game(IMediator mediator)
			: base(mediator)
		{ }

		public override void Notify(string message)
		{
			Console.WriteLine("Игра, " + message);
		}
	}
}