namespace DependencyInjection
{
	/// <summary>
	/// Билет.
	/// </summary>
	internal interface ITicket
	{
		/// <summary>
		/// Пункт назначения.
		/// </summary>
		City To { get; set; }

		/// <summary>
		/// Кто едет.
		/// </summary>
		IHuman Human { get; set; }

		/// <summary>
		/// На какой транспорт этот билет.
		/// </summary>
		ITransport Transport { get; set; }

		/// <summary>
		/// Использовать билет.
		/// </summary>
		void Use();
	}
}
