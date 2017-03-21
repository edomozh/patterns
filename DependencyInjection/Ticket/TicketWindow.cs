namespace DependencyInjection
{
	using System;
	using System.CodeDom;
	using System.Linq;

	/// <summary>
	/// Касса.
	/// </summary>
	internal class TicketWindow : ITicketFactory
	{
		private readonly ICityMap _cityMap;

		public TicketWindow(ICityMap cityMap)
		{
			_cityMap = cityMap;
		}

		/// <summary>
		/// Купить билет.
		/// </summary>
		/// <param name="who">Кто.</param>
		/// <param name="cityName">Город.</param>
		/// <param name="requiredTransport">Требование типа транспорта.</param>
		/// <returns>Билет.</returns>
		public ITicket Buy(IHuman who, string cityName, string requiredTransport)
		{
			if (who == null)
			{
				throw new ArgumentNullException(nameof(who));
			}
			if (cityName == null)
			{
				throw new ArgumentNullException(nameof(cityName));
			}
			if (requiredTransport == null)
			{
				throw new ArgumentNullException(nameof(requiredTransport));
			}

			var where = _cityMap.Find(cityName);
			if (where == null)
			{
				throw new NullReferenceException($"Пункт назначения '{cityName}' не найден.");
			}

			var route = _cityMap.GetRoute(who.City, where, t => t.GetType().Name == requiredTransport);
			if (route == null)
			{
				throw new NullReferenceException($"Маршрута из {who.City.Name} в {where.Name} на транспорте '{requiredTransport}' не существует.");
			}

			return new Ticket<ITransport>(who, where, route.Item3);

		}

	}
}
