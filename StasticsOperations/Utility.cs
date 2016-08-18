using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StasticsOperations
{
	class Utility
	{

		public static void print(int[] data)
		{
			string message = "";
			foreach (int i in data)
			{
				message = message + ", " + i.ToString();
			}
			Console.WriteLine(message);
		}
	}
}
