namespace Mediator
{
	using System;

	/// <summary>
	/// Игровой объект пользователь.
	/// </summary>
	class User : GameObject
	{
		public User(IMediator mediator) : base(mediator) { }

		/// <summary>
		/// Вывод получателя и сообщения.
		/// </summary>
		/// <param name="message"></param>
		public override void Notify(string message)
		{
			Console.WriteLine("Пользователь, " + message);
		}
	}
}