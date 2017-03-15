namespace DependencyInjection
{
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
			City = city;
			Name = name;
		}


	}
}
