namespace Adapter
{
	using System;

	class User
	{
		public event Action<string> Message;
		public void HammerANail(ICanHammerANail tool)
		{
			Message?.Invoke($"I hammered a nail using {tool.ToolName}.");
			tool.HammerANail();
		}
	}
}
