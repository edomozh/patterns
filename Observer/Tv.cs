namespace Observer
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// �����������.
	/// </summary>
	internal class Tv : IObservable
	{
		/// <summary>
		/// ����������� ����������.
		/// </summary>
		private int _channel;

		private readonly Random _rnd = new Random();

		/// <summary>
		/// ������ ������������.
		/// </summary>
		private readonly List<IObserver> _observers;

		public Tv()
		{
			_observers = new List<IObserver>();
		}

		/// <summary>
		/// ���������� �����������.
		/// </summary>
		/// <param name="o"></param>
		public void RegisterObserver(IObserver o)
		{
			_observers.Add(o);
		}

		/// <summary>
		/// �������� �����������.
		/// </summary>
		/// <param name="o"></param>
		public void RemoveObserver(IObserver o)
		{
			_observers.Remove(o);
		}

		/// <summary>
		/// ����������� ���� ������������.
		/// </summary>
		public void NotifyObservers()
		{
			foreach (var o in _observers)
			{
				o.Update(_channel);
			}
		}

		/// <summary>
		/// ������� �� �������� ���������� �����������.
		/// </summary>
		public void StartShow()
		{
			_channel = _rnd.Next(1, 10);
			NotifyObservers();
		}
	}
}