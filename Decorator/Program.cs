namespace Decorator
{
	using System;

	class Program
	{
		static void Main()
		{
			Controller.Message += Console.WriteLine;
			string command;
			do
			{
				command = Console.ReadLine();
				try
				{
					Controller.Command(command);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			} while (command != "exit");
		}
	}
}
