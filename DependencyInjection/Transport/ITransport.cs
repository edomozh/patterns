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
		void Carry(IHuman human, City city);
	}
}