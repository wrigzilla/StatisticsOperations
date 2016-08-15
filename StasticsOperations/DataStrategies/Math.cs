using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StasticsOperations.DataStrategies
{
	class MathOperations
	{
		public static int Sum(int[] data)
		{
			int i = 0; int sum = 0;
			while (i < data.Length)
			{
				sum = sum + data[i++];
			}
			return sum;
		}

		public static double Sum(double[] data)
		{
			int i = 0; double sum = 0;
			while (i < data.Length)
			{
				sum = sum + data[i++];
			}
			return sum;
		}

		public static double Mean(int[] data)
		{
			return (double)Sum(data) / data.Length;
		}

		public static double Mean(double[] data)
		{
			return Sum(data) / data.Length;
		}

		public static int Range(int[] data)
		{
			return GreatestValue(data) - LowestValue(data);
		}


		//possilbe to have multiple mode values 
		public static int[] Mode(int[] data)
		{
			//most common value
			int i = 0; int length = data.Length;
			int count = 0; int number = 0;
			while (i < length)
			{
				if (i == 0)
				{
					number = data[i];
					count = 1;
				}
				else
				{
					if (data[i] == number) count++;
				}
			}
			return new int[1];
		}

		public static int[] DistinctData(int[] data)
		{
			int i = 0; int length = data.Length;
			List<int> distinct = new List<int>();
			while (i < length)
			{
				if (!distinct.Contains(data[i]))
				{
					distinct.Add(data[i]);
				}
				i++;
			}
			return distinct.ToArray();
		}

		public static int[] CountDuplicates(int[] data)
		{


			return new int[1];
		}

		public static void Median(int[] data)
		{
			//middle value
		}


		public static int GreatestValue(int[] data)
		{
			int i = 0; int current = 0; int length = data.Length;
			while (i < length)
			{
				if (i == 0)
				{
					current = data[i];
				}
				else
				{
					if (data[i] > current) current = data[i];
				}
				i++;
			}
			return current;
		}

		public static int LowestValue(int[] data)
		{
			int i = 0; int current = 0; int length = data.Length;
			while (i < length)
			{
				if (i == 0) current = data[i];
				else
				{
					if (data[i] < current) current = data[i];
				}
				i++;
			}
			return current;
		}


		public static double[] DifferenceFromMean(int[] data)
		{
			int i = 0; int length = data.Length; double[] difference = new double[length];
			double mean = Mean(data);

			while (i < length)
			{
				difference[i] = data[i] - mean;
				i++;
			}
			return difference;
		}

		public static double VarianceFromMean(int[] data)
		{
			double[] meanDifference = DifferenceFromMean(data);
			double[] meanDifferenceSquared = Square(meanDifference);
			return Mean(meanDifferenceSquared);
		}


		/* 
		 * Point to note, StandardDeviation uses a standard mean calculation (as if calculating for a whole population)  (sum of n) / n 
		 * does not use Bessel's correction for only a sample which is (sum o f n) / n-1
		 * see https://en.wikipedia.org/wiki/Bessel%27s_correction for more detials
		 */
		public static double StandardDeviation(int[] data)
		{
			return Math.Sqrt(VarianceFromMean(data));
		}



		public static int[] Square(int[] data)
		{
			int i = 0; int length = data.Length;
			while (i < length)
			{
				data[i] = data[i] * data[i];
				i++;
			}
			return data;
		}

		public static double[] Square(double[] data)
		{
			int i = 0; int length = data.Length;
			while (i < length)
			{
				data[i] = data[i] * data[i];
				i++;
			}
			return data;
		}
	}
}
