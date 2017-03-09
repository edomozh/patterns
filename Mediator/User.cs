namespace Mediator
{
	using System;

	class User : GameObject
	{
		public User(IMediator mediator) : base(mediator) { }

		public override void Notify(string message)
		{
			Console.WriteLine("Пользователь, " + message);
		}
	}
}