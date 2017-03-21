namespace DependencyInjection
{
	using System;

	/// <summary>
	/// Человек.
	/// </summary>
	internal class Man : IHuman
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get;}

		/// <summary>
		/// Расположение.
		/// </summary>
		public City City { get; set; }

		/// <summary>
		/// Конструктор мужчины.
		/// </summary>
		/// <param name="name">Имя мужчины.</param>
		/// <param name="city">Начальное положение.</param>
		internal Man(string name, City city)
		{
			if (name == null)
			{
				throw new ArgumentNullException(nameof(name));
			}
			if (city == null)
			{
				throw new ArgumentNullException(nameof(city));
			}
			City = city;
			Name = name;
		}


	}
}
