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

		public static void Main()
		{
			var map = new CommonCityMap(
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
							new RailwayStation(),
							new Port()
						}
					)
				}
			);

			// Регистрация служб.
			Console.WriteLine("Регистрируем службы.");
			Container.Register<ICityMap, CommonCityMap>(map);
			Container.Register<ITicketFactory>(container => new TicketWindow(container.Resolve<ICityMap>()));

			do
			{
				try
				{
					Console.Clear();
					Console.WriteLine("Для создания персонажа:");
					Console.WriteLine("Введите название города:");
					foreach (var i in Container.Resolve<ICityMap>().Cities)
					{
						Console.WriteLine($"\t{i.Name}");
					}
					var cityName = Console.ReadLine();

					// Берем город.
					var city = Container.Resolve<ICityMap>().Cities.FirstOrDefault(c => c.Name == cityName);
					if (city == null)
					{
						throw new NullReferenceException($"Города '{cityName}' не найдено.");
					}

					Console.WriteLine("\r\nВведите имя человека.");
					var manName = Console.ReadLine();

					// Создаем человека в городе.
					var man = new Man(manName, city);
					Console.WriteLine($"\r\n{man.Name} в городе {man.City.Name}.");

					Console.WriteLine("Для покупки билета:");
					Console.WriteLine("Введите название транспорта (Airplane, Train, Bus, Ship):");
					var transport = Console.ReadLine();

					Console.WriteLine("\r\nВведите пункт назначения:");
					var pointName = Console.ReadLine();

					// Берем для него билетик.
					var ticket = Container.Resolve<ITicketFactory>().Buy(man, pointName, transport);

					// Используем билетик.
					ticket.Use();
					Console.WriteLine($"\r\n{man.Name} в городе {man.City.Name}.");

				}
				catch (Exception e)
				{
					Console.WriteLine($"\r\n{e.Message}");
				}
			} while (Console.ReadLine() != "exit");
		}
	}
}
