namespace DependencyInjection
{
	/// <summary>
	/// Транспорт.
	/// </summary>
	internal interface ITransport
	{
		/// <summary>
		/// Передвигаться.
		/// </summary>
		/// <param name="text"></param>
		void Go(string text);
	}
}