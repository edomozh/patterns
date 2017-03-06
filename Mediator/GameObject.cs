namespace Mediator
{
	internal abstract class GameObject
	{
		public readonly IManager Manager;

		public GameObject(IManager manager)
		{
			Manager = manager;
		}

		internal abstract string Notify(string msg);
	}
}