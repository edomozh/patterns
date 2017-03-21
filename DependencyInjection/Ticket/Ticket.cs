namespace DependencyInjection
{
	using System;

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
		/// <param name="transport">Транспорт.</param>
		public Ticket(IHuman who, City to, TTRansport transport)
		{
			if (who == null)
			{
				throw new ArgumentNullException(nameof(who));
			}
			if (to == null)
			{
				throw new ArgumentNullException(nameof(to));
			}
			if (transport == null)
			{
				throw new ArgumentNullException(nameof(transport));
			}
			Human = who;
			To = to;
			Transport = transport;
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
