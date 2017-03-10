namespace DependencyInjection
{
	/// <summary>
	/// Путешественник.
	/// </summary>
	internal class Traveler
	{
		// Имя.
		private string Name { get; }

		/// <summary>
		/// Транспорт путешественника.
		/// </summary>
		public ITransport Transport { private get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя.</param>
		/// <param name="transport">Транспорт.</param>
		public Traveler(string name, ITransport transport)
		{
			Transport = transport;
			Name = name;
		}

		/// <summary>
		/// Путешествовать.
		/// </summary>
		public void Travel()
		{
			Transport.Go(Name);
		}
	}
}