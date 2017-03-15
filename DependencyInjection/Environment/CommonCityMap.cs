namespace DependencyInjection
{
	using System.Collections.Generic;

	/// <summary>
	/// Обычная карта городов.
	/// </summary>
	internal class CommonCityMap : ICityMap
	{
		/// <summary>
		/// Города.
		/// </summary>
		public ICollection<City> Cities {get; set;}

		/// <summary>
		/// Инициализация карты из конструктора.
		/// </summary>
		/// <param name="cities">Города.</param>
		public CommonCityMap(ICollection<City> cities)
		{
			Cities = cities;
		}

	}
}
