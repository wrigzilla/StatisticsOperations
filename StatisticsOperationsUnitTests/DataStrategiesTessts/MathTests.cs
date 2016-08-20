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

		#region CoveredTests
		//tests
		public bool SquareTest()
		{
			int[] num = { 1, 2, 3, 4 };
			num = MathOperations.Square(num);
			if (num.ToList().Sum() == 30)
			{
				return true;
			}
			return false;
		}

		public bool SumTest()
		{
			int[] a = { 1, 2, 3, 4 };
			if (MathOperations.Sum(a) == 10)
			{
				return true;
			}
			//need to test double[] and int[]
			return false;
		}

		public bool GreatestValueTest()
		{
			int[] num = { 2,5,9,7,5,3,2 };
			int result = MathOperations.GreatestValue(num);
			if (result == 9)
			{
				return true;
			}
			return false;
		}

		public bool LowestValueTest()
		{
			int[] num = { 2, 5, 9, 7, 5, 3, 2 };
			int result = MathOperations.LowestValue(num);
			if (result == 2)
			{
				return true;
			}
			return false;
		}

		public bool MeanTest()
		{
			//test with int[] double[]
			int[] a = { 2, 3, 4, 5 };
			if (MathOperations.Mean(a) == 3.5)
			{
				return true;
			}
			return false;
		}

		public bool RangeTest()
		{
			int[] a = { 1, 2, 3, 4 };
			if (MathOperations.Range(a) == 3)
			{
				return true;
			}
			return false;
		}

		public bool DistinctData()
		{
			int[] data = { 0, 1, 1, 2 };
			if (MathOperations.DistinctData(data) == new int[] { 0, 1, 2 } )
			{

			}


			return false;
		}

		public bool MedianTest()
		{
			bool evenArrayLength = false;
			bool oddArrayLength = false;

			int[] a = { 4, 5, 6, 7, 8 };
			if (MathOperations.Median(a) == 6)
			{
				oddArrayLength = true;
			}

			a = new int[] { 4, 5, 6, 7 };
			if (MathOperations.Median(a) == 5.5)
			{
				evenArrayLength = true;
			}

			return evenArrayLength && oddArrayLength;

			//should properly test this function as it has different behaviour based upon
		}


		#endregion


		#region TestsToFinish


		public bool ModeTest(int[] data)
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

		#endregion
	}
}
