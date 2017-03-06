namespace Mediator
{
	internal interface IManager
	{
		User User { get; set; }
		Game Game { get; set; }
		Menu Menu { get; set; }

		string Send(GameObject sender, string msg);
	}
}