namespace DependencyInjection
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// Обычная карта городов.
	/// </summary>
	internal class CommonCityMap : ICityMap
	{
		/// <summary>
		/// Города.
		/// </summary>
		public ICollection<City> Cities { get; set; }

		/// <summary>
		/// Маршруты.
		/// </summary>
		public ICollection<Tuple<City, City, ITransport>> Routes { get; set; } 
			= new List<Tuple<City, City, ITransport>>();

		/// <summary>
		/// Инициализация карты из конструктора.
		/// </summary>
		/// <param name="cities">Города.</param>
		public CommonCityMap(ICollection<City> cities)
		{
			if (cities == null)
			{
				throw new ArgumentNullException(nameof(cities));
			}
			Cities = cities;

			// Заполнение маршрутов. Выделение транспорта на них.
			foreach (var city in cities)
			{
				foreach (var city2 in cities)
				{
					var existWay = false;
					if (city.Name == city2.Name) continue;
					foreach (var point in city.ArrivalPoints)
					{
						foreach (var point2 in city2.ArrivalPoints)
						{
							if (point.GetType() == point2.GetType())
							{
								existWay = true;
								var act = new Dictionary<Type, Action> {
									{ typeof(Airport), () => Routes.Add(new Tuple<City, City, ITransport>(city,city2,new Airplane())) },
									{ typeof(RailwayStation), () => Routes.Add(new Tuple<City, City, ITransport>(city,city2,new Train())) },
									{ typeof(Port), () => Routes.Add(new Tuple<City, City, ITransport>(city,city2,new Ship())) }
								};
								act[point.GetType()]();
							}
							if (!existWay)
							{
								Routes.Add(new Tuple<City, City, ITransport>(city, city2, new Bus()));
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// Найти город.
		/// </summary>
		/// <param name="name">Название города.</param>
		/// <returns>Город.</returns>
		public City Find(string name)
		{
			return Cities.FirstOrDefault(c => c.Name == name);
		}

		/// <summary>
		/// Получить маршрут.
		/// </summary>
		/// <param name="from">Откуда.</param>
		/// <param name="to">Куда.</param>
		/// <param name="demesne">Требование.</param>
		/// <returns>Маршрут.</returns>
		public Tuple<City, City, ITransport> GetRoute(City from, City to, Func<ITransport, bool> demesne)
		{
			return Routes.FirstOrDefault(route => 
			route.Item1 == from && route.Item2 == to && demesne(route.Item3) || 
			route.Item2 == from && route.Item1 == to && demesne(route.Item3));
		}
	}
}
