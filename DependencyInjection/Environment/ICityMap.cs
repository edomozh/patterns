namespace DependencyInjection
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Интерфейс карты городов.
	/// </summary>
	internal interface ICityMap
	{
		/// <summary>
		/// Города.
		/// </summary>
		ICollection<City> Cities { get; set; }

		/// <summary>
		/// Маршруты.
		/// </summary>
		ICollection<Tuple<City, City, ITransport>> Routes { get; set; }

		/// <summary>
		/// Найти город.
		/// </summary>
		/// <param name="name">Название.</param>
		/// <returns>Город.</returns>
		City Find(string name);

		/// <summary>
		/// Получить маршрут.
		/// </summary>
		/// <param name="from">От куда.</param>
		/// <param name="to">Куда.</param>
		/// <param name="demesne">Требование конкретного транспорта.</param>
		/// <returns>Маршрут.</returns>
		Tuple<City, City, ITransport> GetRoute(City from, City to, Func<ITransport, bool> demesne);
	}
}
