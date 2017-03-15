namespace DependencyInjection
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	internal static class Program
	{
		/// <summary>
		/// Inversion of Control Контейнер.
		/// </summary>
		private static Container Container { get; } = new Container();

		/// <summary>
		/// Карта городов для путешествий.
		/// </summary>
		private static CommonCityMap CommonCityMap { get; } = new CommonCityMap(
			new List<City>
			{
				new City("Нижний Новгород",
					new List<Station>
					{
						new Airport(),
						new Port()
					}
				),
				new City("Москва",
					new List<Station>
					{
						new Airport(),
					}
				),
				new City("Казань",
					new List<Station>
					{
						new RailwaySstation(),
						new RailwaySstation(),
						new Port()
					}
				)
			}
		);

		/// <summary>
		/// Фабрика билетов.
		/// </summary>
		private static TicketWindow TicketWindow { get; } = new TicketWindow();

		/// <summary>
		/// Фабрика транспорта.
		/// </summary>
		private static Сamp Сamp { get; } = new Сamp(
				new List<ITransport>
				{
					new Ship(),
					new Bus(),
					new Airplane(),
					new Train()
				}
			);

		public static void Main()
		{
			// Регистрация служб.
			Container.Register<ICityMap, CommonCityMap>(CommonCityMap);
			Container.Register<ITicketFactory, TicketWindow>(TicketWindow);
			Container.Register<ITransportFactory, Сamp>(Сamp);
			// Люди все одинаковы.
			Container.Register<IHuman>(m => new Man("Иван Иванов", Container.Resolve<ICityMap>().Cities.First(c => c.Name == "Нижний Новгород")));

			// Берем экземпляр человека.
			var man = Container.Resolve<IHuman>();
			Console.WriteLine($"{man.Name} в городе {man.City.Name}.");

			// Берем для него билетик.
			var ticket = Container.Resolve<ITicketFactory>().Buy(
				man,
				Container.Resolve<ICityMap>().Cities.First(c => c.Name == "Казань"),
				Container);

			// Используем билетик.
			ticket.Use();
			Console.WriteLine($"{man.Name} в городе {man.City.Name}.");

			Console.ReadLine();
		}
	}
}
