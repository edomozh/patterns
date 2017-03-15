namespace DependencyInjection
{
	using System;
	using System.Linq;

	/// <summary>
	/// Касса.
	/// </summary>
	internal class TicketWindow : ITicketFactory
	{
		/// <summary>
		/// Купить билет.
		/// </summary>
		/// <param name="who">Кто.</param>
		/// <param name="where">Куда.</param>
		/// <param name="container">Контейнер.</param>
		/// <returns></returns>
		public ITicket Buy(IHuman who, City where, Container container)
		{
			if (who == null)
			{
				throw new NullReferenceException(nameof(who));
			}
			if (where == null)
			{
				throw new NullReferenceException(nameof(where));
			}
			if (container == null)
			{
				throw new NullReferenceException(nameof(container));
			}

			if (who.City.ArrivalPoints.OfType<Airport>().Count(p => true) > 0 &&
				where.ArrivalPoints.OfType<Airport>().Count(p => true) > 0)
			{
				return new Ticket<Airplane>(who, where, container);
			}
			if (who.City.ArrivalPoints.OfType<Port>().Count(p => true) > 0 &&
				where.ArrivalPoints.OfType<Port>().Count(p => true) > 0)
			{
				return new Ticket<Ship>(who, where, container);
			}
			if (who.City.ArrivalPoints.OfType<RailwaySstation>().Count(p => true) > 0 &&
				where.ArrivalPoints.OfType<RailwaySstation>().Count(p => true) > 0)
			{
				return new Ticket<Train>(who, where, container);
			}
			return new Ticket<Bus>(who, where, container);
		}
	}
}
