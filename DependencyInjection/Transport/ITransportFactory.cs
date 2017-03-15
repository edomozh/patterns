namespace DependencyInjection
{
	using System;

	internal interface ITransportFactory
	{
		/// <summary>
		/// Поставить транспорт.
		/// </summary>
		/// <returns>Транспорт.</returns>
		ITransport Supply(Type type);
	}
}
