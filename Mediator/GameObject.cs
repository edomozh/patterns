namespace Mediator
{
	abstract class GameObject
	{
		protected IMediator mediator;

		public GameObject(IMediator mediator)
		{
			this.mediator = mediator;
		}

		public virtual void Send(string message)
		{
			mediator.Send(message, this);
		}
		public abstract void Notify(string message);
	}
}