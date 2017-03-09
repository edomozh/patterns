namespace Observer
{
	using System;

	class Program
	{
		static void Main()
		{
			var tv = new Tv();
			var user1 = new Viewer("Иван Иваныч", tv);
			var user2 = new Viewer("Иван Палыч", tv);

			tv.StartShow();
			tv.StartShow();

			user1.Unfollow();
			user2.Unfollow();

			tv.StartShow();
			Console.Read();
		}
	}
}
