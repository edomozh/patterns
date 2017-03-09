namespace Mediator
{
	using System;

	/// <summary>
	/// Игровой объект меню.
	/// </summary>
	class Menu : GameObject
	{
		public Menu(IMediator mediator) : base(mediator) { }

		/// <summary>
		/// Выводит кто получил и что.
		/// </summary>
		/// <param name="message"></param>
		public override void Notify(string message)
		{
			Console.WriteLine("Меню, " + message);
		}
	}
}