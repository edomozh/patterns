namespace DependencyInjection
{
	using System.Collections.Generic;

	/// <summary>
	/// Город.
	/// </summary>
	internal sealed class City
	{
		/// <summary>
		/// Название.
		/// </summary>
		internal string Name { get; set; }

		/// <summary>
		/// Список станций в городе.
		/// </summary>
		internal ICollection<Station> ArrivalPoints { get; private set; }

		/// <summary>
		/// Инициализация города.
		/// </summary>
		/// <param name="name">Название города.</param>
		/// <param name="arrivalPoints">Станции в городе.</param>
		public City(string name, ICollection<Station> arrivalPoints)
		{
			ArrivalPoints = arrivalPoints;
			Name = name;
		}
	}
}
