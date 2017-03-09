namespace Mediator
{
	/// <summary>
	/// Объект игровой системмы.
	/// </summary>
	abstract class GameObject
	{
		/// <summary>
		/// Посредник.
		/// </summary>
		protected IMediator Mediator;

		/// <summary>
		/// При инициализации указывается посредник.
		/// </summary>
		public GameObject(IMediator mediator)
		{
			this.Mediator = mediator;
		}

		/// <summary>
		/// Перенаправление сообщения с помощью посредника.
		/// </summary>
		public virtual void Send(string message)
		{
			Mediator.Send(message, this);
		}

		/// <summary>
		/// Обработка входящего уведомления.
		/// </summary>
		/// <param name="message"></param>
		public abstract void Notify(string message);
	}
}