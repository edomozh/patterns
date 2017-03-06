namespace Singletone
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MyGirl.Instance.Call("Where are u?"));
			Console.ReadLine();
		}
	}
}
