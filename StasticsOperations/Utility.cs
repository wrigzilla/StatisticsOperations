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
			int i = 0; int length = data.Length;
			while (i < length)
			{
				message += ((i == 0) ? "" : ",") + data[i].ToString();
				i++;
			}
			Console.WriteLine(message);
		}
	}
}
