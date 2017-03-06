using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
	using Patterns.Singleton;

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MyGirl.Instance.Call("Where are u?"));
			Console.ReadLine();
		}
	}
}
