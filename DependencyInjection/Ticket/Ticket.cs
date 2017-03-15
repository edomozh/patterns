namespace DependencyInjection
{
	/// <summary>
	/// Билет.
	/// </summary>
	/// <typeparam name="TTRansport">На какой тип транспорта он рапространяется.</typeparam>
	internal class Ticket<TTRansport> : ITicket
		where TTRansport : ITransport
	{
		/// <summary>
		/// На кого билет.
		/// </summary>
		public IHuman Human { get; set; }

		/// <summary>
		/// Куда билет.
		/// </summary>
		public City To { get; set; }

		/// <summary>
		/// На какой транспорт.
		/// </summary>
		public ITransport Transport { get; set; }

		/// <summary>
		/// Инициализировать билет.
		/// </summary>
		/// <param name="who">На кого.</param>
		/// <param name="to">Куда.</param>
		/// <param name="container">Контейнер для получения фабрики транспорта.</param>
		public Ticket(IHuman who, City to, Container container)
		{
			Human = who;
			To = to;
			Transport = container.Resolve<ITransportFactory>().Supply(typeof(TTRansport));
		}

		/// <summary>
		/// Использовать билет.
		/// </summary>
		public void Use()
		{
			Transport.Carry(Human, To);
		}

	}
}
