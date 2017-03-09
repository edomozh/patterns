namespace Mediator
{
	using System;

	/// <summary>
	/// Обьект игра.
	/// </summary>
	class Game : GameObject
	{
		public Game(IMediator mediator) : base(mediator) { }

		/// <summary>
		/// Уведомление игре.
		/// </summary>
		/// <param name="message"></param>
		public override void Notify(string message)
		{
			Console.WriteLine("Игра, " + message);
		}
	}
}