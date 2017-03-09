namespace Mediator
{
	using System;

	class Menu : GameObject
	{
		public Menu(IMediator mediator) : base(mediator) { }

		public override void Notify(string message)
		{
			Console.WriteLine("Меню, " + message);
		}
	}
}