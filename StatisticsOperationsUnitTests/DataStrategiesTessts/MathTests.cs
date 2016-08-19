using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StasticsOperations;
using StasticsOperations.DataStrategies;

namespace StatisticsOperationsUnitTests.DataStrategiesTessts
{
	class MathOperationsTests
	{
		public MathOperationsTests()
		{
			Console.WriteLine("Initialize Math Operations Test");
		}

		//tests
		public bool SquareTest(int[] data)
		{
			int[] num = { 1, 2, 3, 4 };
			num = MathOperations.Square(num);

			if (num.ToList().Sum() == 30)
			{
				return true;
			}
			return false;
		}

		public bool SumTest(int[] data)
		{
			int[] a = { 1, 2, 3, 4, 4 };

			MathOperations.Sum(a);

			//need to test double[] and int[]

			return false;
		}

		public bool GreatestValueTest(int[] data)
		{
			int[] num = { 2,5,9,7,5,3,2 };
			int result = MathOperations.GreatestValue(num);

			if (result == 9)
			{
				return true;
			}
			return false;
		}

		public bool LowestValueTest(int[] data)
		{
			return false;
		}


		public bool MeanTest(int [] data)
		{
			//test with int[] double[]
			return false;
		}

		public bool RangeTest(int[] data)
		{
			return false;
		}

		public bool ModeTest(int[] data)
		{
			return false;
		}

		public bool MedianTest(int[] data)
		{
			return false;
		}

		public bool DistinctData(int[] data)
		{
			return false;
		}

		public bool CountDuplicatesTest(int[] data)
		{
			return false;
		}

		public bool countDuplicateTest(int[] data, int num)
		{
			return false;
		}

		

		

		public bool DifferenceFromMeanTest(int[] data)
		{
			return false;
		}

		public bool VarianceFromMeanTest(int[] data)
		{
			return false;
		}

		public bool StandardDeviationTest(int[] data)
		{
			return false;
		}
	}
}
