namespace DependencyInjection
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// Стоянка транспорта.
	/// </summary>
	internal class Сamp : ITransportFactory
	{
		/// <summary>
		/// Имеющийся транспорт.
		/// </summary>
		private ICollection<ITransport> Transport { get; set; }

		/// <summary>
		/// Инициализация фабрики.
		/// </summary>
		/// <param name="transport">Транспорт в наличии.</param>
		public Сamp(ICollection<ITransport> transport)
		{
			Transport = transport;
		}

		/// <summary>
		/// Поставить транспорт.
		/// </summary>
		/// <returns></returns>
		public ITransport Supply(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException(nameof(type));
			}
			if (!type.GetInterfaces().Contains(typeof(ITransport)))
			{
				throw new ArgumentException("Нет такого транспорта.");
			}

			ITransport transport = null;
			if (type == typeof(Airplane))
			{
				transport = Transport.OfType<Airplane>().FirstOrDefault();
			}
			if (type == typeof(Ship))
			{
				transport = Transport.OfType<Ship>().FirstOrDefault();
			}
			if (type == typeof(Train))
			{
				transport = Transport.OfType<Train>().FirstOrDefault();
			}
			if (type == typeof(Bus))
			{
				transport = Transport.OfType<Bus>().FirstOrDefault();
			}
			if (transport == null)
			{
				throw new NullReferenceException("Нет такого транспорта.");
			}
			return transport;

		}
	}
}
