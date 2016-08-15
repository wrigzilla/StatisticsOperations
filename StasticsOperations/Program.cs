using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StasticsOperations.DataStrategies;

namespace StasticsOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello!");

			int[] data = { 1,1,2,3,3,4,4,4,5,6,7 };

			//Console.WriteLine(MathOperations.Sum(data));
			//Console.WriteLine(MathOperations.GreatestValue(data));
			//Console.WriteLine(MathOperations.LowestValue(data));
			//Console.WriteLine(MathOperations.Range(data));
			Console.WriteLine("Mean = " + MathOperations.Mean(data).ToString());
			//Console.WriteLine(MathOperations.DifferenceFromMean(data).ToString());
			Console.WriteLine("Variance = " + MathOperations.VarianceFromMean(data).ToString());
			Console.WriteLine("Standard Deviation = " + MathOperations.StandardDeviation(data).ToString());
			Console.WriteLine("Mode = " + MathOperations.Mode(data).ToString());
		}
	}
}
