namespace DependencyInjection
{
	/// <summary>
	/// ���������.
	/// </summary>
	internal interface ITransport
	{
		/// <summary>
		/// �������������.
		/// </summary>
		/// <param name="text"></param>
		void Go(string text);
	}
}