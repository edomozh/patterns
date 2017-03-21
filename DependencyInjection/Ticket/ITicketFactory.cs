namespace DependencyInjection
{
	/// <summary>
	/// Производитель билетов.
	/// </summary>
	internal interface ITicketFactory
	{
		/// <summary>
		/// Сделать билет.
		/// </summary>
		/// <param name="who">На кого.</param>
		/// <param name="cityName">Куда.</param>
		/// <param name="requiredTransport">Требование типа транспорта.</param>
		/// <returns>Билет.</returns>
		ITicket Buy(IHuman who, string cityName, string requiredTransport);
	}
}
