namespace Decorator
{
	/// <summary>
	/// Класс для хранения декорируемого объекта.
	/// </summary>
	abstract class LadyDecorator : Lady
	{
		protected readonly Lady Lady;

		protected LadyDecorator(string name, Lady lady) : base(name)
		{
			Lady = lady;
		}
	}
}