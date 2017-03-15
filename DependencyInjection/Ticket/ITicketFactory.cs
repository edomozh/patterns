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
		/// <param name="where">Куда.</param>
		/// <param name="con">Контейнер.</param>
		/// <returns>Билет.</returns>
		ITicket Buy(IHuman who, City where, Container con);
	}
}
