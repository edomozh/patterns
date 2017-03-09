namespace Observer
{
	using System;

	/// <summary>
	/// Зритель.
	/// </summary>
	internal class Viewer : IObserver
	{
		/// <summary>
		/// Имя.
		/// </summary>
		private string Name { get; set; }

		/// <summary>
		/// Наблюдаемый объект.
		/// </summary>
		private IObservable _tv;

		/// <summary>
		/// При инициализации указывается имя и наблюдаемый объект.
		/// </summary>
		public Viewer(string name, IObservable obs)
		{
			Name = name;
			_tv = obs;
			_tv.RegisterObserver(this);
		}

		/// <summary>
		/// Событие обновления наблюдаемого объекта.
		/// </summary>
		public void Update(object channel)
		{
			var info = (int)channel;
			Console.WriteLine($"Похоже по каналу {info} началось шоу. (С) {Name}");
		}

		/// <summary>
		/// Отписка от наблюдения.
		/// </summary>
		public void Unfollow()
		{
			_tv.RemoveObserver(this);
			_tv = null;
		}
	}
}