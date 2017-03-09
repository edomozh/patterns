namespace Observer
{
	/// <summary>
	/// Наблюдаемый объект.
	/// </summary>
	internal interface IObservable
	{
		/// <summary>
		/// Регистрация наблюдателя.
		/// </summary>
		void RegisterObserver(IObserver o);

		/// <summary>
		/// Удаление наблюдателя.
		/// </summary>
		void RemoveObserver(IObserver o);

		/// <summary>
		/// Уведомление наблюдателей.
		/// </summary>
		void NotifyObservers();
	}
}