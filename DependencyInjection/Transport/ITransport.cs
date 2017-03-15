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
		void Carry(IHuman human, City city);
	}
}