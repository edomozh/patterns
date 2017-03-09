namespace Observer
{
	/// <summary>
	/// Наблюдатель.
	/// </summary>
	internal interface IObserver
	{
		void Update(object channel);
	}
}