using System;
using System.Collections.Generic;

namespace StasticsOperations.DataStrategies
{
	public class MathOperations
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

		public static double Median(int[] data)
		{
			int length = data.Length;
			Array.Sort(data);
			double halfLength = length * 0.5;

			if (length % 2 == 0)
			{
				return (data[(int)halfLength - 1] + data[(int)halfLength]) * 0.5;
			}
			int n = (int)Math.Round(halfLength, MidpointRounding.AwayFromZero);
			return data[n - 1];
		}

		//possilbe to have multiple mode values 
		public static int[] Mode(int[] data)
		{
			int[] duplicatsCount = CountDuplicates(data);
			int[] distinct = DistinctData(data);

			int i = 0; int length = duplicatsCount.Length;
			int number = 0;

			List<int> modeIndexes = new List<int>();

			while (i < length)
			{
				if (i == 0)
				{
					number = duplicatsCount[i];
					modeIndexes.Add(i);
				}
				else
				{
					if (duplicatsCount[i] == number) modeIndexes.Add(i);
					if (duplicatsCount[i] > number)
					{
						number = duplicatsCount[i];
						modeIndexes.Clear();
						modeIndexes.Add(i);
					}
				}
				i++;
			}

			modeIndexes.ForEach(delegate(int item)
			{
				item = distinct[item];
			});

			return modeIndexes.ToArray();
		}	//this one is a bitch


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
			int[] distinct = DistinctData(data);
			int[] counts = new int[distinct.Length];
			int i = 0; int length = distinct.Length;

			while (i < length)
			{
				counts[i] = countDuplicate(data, distinct[i]);
				i++;
			}
			return counts;
		}

		public static int countDuplicate(int[] data, int num)
		{
			int i = 0; int length = data.Length; int count = 0;
			while (i < length)
			{
				if (data[i] == num) count++;
				i++;
			}
			return count;
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
