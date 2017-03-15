namespace DependencyInjection
{
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
	}
}
