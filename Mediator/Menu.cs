namespace Mediator
{
	using System;

	internal class Menu : GameObject
	{
		internal bool Active { get; }

		public Menu(IManager manager) : base(manager)
		{
			Active = true;
			manager.Menu = this;
		}

		public string Start()
		{
			Console.Clear();
			Console.WriteLine("MENU:");
			Console.WriteLine("1. Start game;");
			Console.WriteLine("3. New User;");
			Console.WriteLine("2. Exit;");

			var input = Console.ReadKey();
			switch (input.Key)
			{
				case ConsoleKey.NumPad1:
					Manager.Send(this, "StartGame"); break;
				case ConsoleKey.NumPad2:
					Manager.Send(this, "StartGame"); break;
				default: return "What?";
			}
			return "I do.";
		}

		internal override string Notify(string msg)
		{
			if (0 == string.Compare(msg, "Open", StringComparison.OrdinalIgnoreCase))
			{
				return Start();
			}
			return "What?";
		}
	}
}