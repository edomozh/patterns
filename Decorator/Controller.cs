namespace Decorator
{
	using System;

	/// <summary>
	/// Класс принимающий команды, и отправляющий их вниз по объектам для обработки.
	/// </summary>
	class Controller
	{
		/// <summary>
		/// Сообщение пользователю от игровых объектов.
		/// </summary>
		public static event Action<string> Message;

		// Военная башня.
		private static readonly WarTower _warTower = new WarTower();

		// Золотодобывающая башня.
		private static readonly GoldTower _goldTower = new GoldTower();

		// Башня исследований.
		private static readonly ProgressTower _progressTower = new ProgressTower();


		/// <summary>
		/// Метод обработчик команд пользователя.
		/// </summary>
		/// <param name="command"></param>
		public static void Command(string command)
		{
			if (command == null || command == "")
			{
				throw new ArgumentNullException(command);
			}
			var m = command.Split(' ');
			if (m.Length < 1)
			{
				throw new ArgumentNullException("You can't use empty command."); 
			}
			switch (m[0])
			{
				case "GoldTower":
					CommandToGoldTower(m[1]); break;
				case "WarTower":
					CommandToWarTower(m[1]); break;
				case "ProgressTower":
					CommandToProgressTower(m[1]); break;
			}
		}

		/// <summary>
		/// Обработчик команды к исследовательской башне.
		/// </summary>
		/// <param name="command"></param>
		private static void CommandToProgressTower(string command)
		{
			foreach (var result in _progressTower.Command(command))
			{
				Message?.Invoke(result);
			}
		}

		/// <summary>
		/// Обработчик команды к оборонительной башне.
		/// </summary>
		/// <param name="command"></param>
		private static void CommandToWarTower(string command)
		{
			Message?.Invoke(_warTower.Command(command));
		}

		/// <summary>
		/// Обработчик команды к золотодобывающей башне.
		/// </summary>
		/// <param name="command"></param>
		private static void CommandToGoldTower(string command)
		{
			Message?.Invoke(_goldTower.Command(command));
		}
	}
}
