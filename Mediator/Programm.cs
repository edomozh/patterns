namespace Mediator
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			var mediator = new GameMediator();

			var user = new User(mediator);
			var menu = new Menu(mediator);
			var game = new Game(mediator);

			mediator.User = user;
			mediator.Menu = menu;
			mediator.Game = game;

			user.Send("Я хочу поиграть.");
			menu.Send("Настройки указаны, запустить игру.");
			game.Send("Запуск игры.");

			Console.Read();
		}
	}
}
