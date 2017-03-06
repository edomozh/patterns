namespace Mediator
{
	internal class User : GameObject
	{
		public User(IManager manager) : base(manager)
		{
			manager.User = this;
		}
	}
}