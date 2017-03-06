namespace Mediator
{
	using System;

	class Program
	{
		static void Main()
		{
			var gameManager = new GameManager();
			var menu = new Menu(gameManager);
			menu.Start();
		}
	}
}
