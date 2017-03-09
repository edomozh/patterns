namespace Mediator
{
	/// <summary>
	/// Интерфейс посредника.
	/// </summary>
	interface IMediator
	{
		void Send(string msg, GameObject gameObject);
	}
}