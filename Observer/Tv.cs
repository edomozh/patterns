namespace Observer
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Телевидение.
	/// </summary>
	internal class Tv : IObservable
	{
		/// <summary>
		/// Наблюдаемая информация.
		/// </summary>
		private int _channel;

		private readonly Random _rnd = new Random();

		/// <summary>
		/// Список наблюдателей.
		/// </summary>
		private readonly List<IObserver> _observers;

		public Tv()
		{
			_observers = new List<IObserver>();
		}

		/// <summary>
		/// Добавление наблюдателя.
		/// </summary>
		/// <param name="o"></param>
		public void RegisterObserver(IObserver o)
		{
			_observers.Add(o);
		}

		/// <summary>
		/// Удаление наблюдателя.
		/// </summary>
		/// <param name="o"></param>
		public void RemoveObserver(IObserver o)
		{
			_observers.Remove(o);
		}

		/// <summary>
		/// Уведомление всех наблюдателей.
		/// </summary>
		public void NotifyObservers()
		{
			foreach (var o in _observers)
			{
				o.Update(_channel);
			}
		}

		/// <summary>
		/// Событие по которому произойдет уведомление.
		/// </summary>
		public void StartShow()
		{
			_channel = _rnd.Next(1, 10);
			NotifyObservers();
		}
	}
}