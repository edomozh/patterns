namespace DependencyInjection
{
	/// <summary>
	/// Человек.
	/// </summary>
	internal interface IHuman
	{
		/// <summary>
		/// Имя.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Расположение.
		/// </summary>
		City City { get; set; }
	}
}
