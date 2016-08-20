using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatisticsOperationsUnitTests.DataStrategiesTessts;

namespace StatisticsOperationsUnitTests.TestManager
{
	class TestManager
	{
		private MathOperationsTests math;
		private List<TestResult> results;

		public TestManager()
		{
			results = new List<TestResult>();
			math = new MathOperationsTests();
		}

		public void runTests()
		{
			if (math == null) math = new MathOperationsTests();
			if (results == null) results = new List<TestResult>();

			log(math.SquareTest(), "Square Test (type int[])");
			log(math.SumTest(), "Sum Test (type int[])");
			log(math.GreatestValueTest(), "Greatest Value Test (type int[])");
			log(math.LowestValueTest(), "Lowest Value Test (type int[])");
			log(math.MeanTest(), "Mean Value Test (type int[])");
			log(math.RangeTest(), "Range Test (type int[])");
			log(math.MedianTest(), "Median Test (type int[])");

			printResults(results);
		}

		public void printResults(List<TestResult> data)
		{
			data.ForEach(delegate (TestResult x)
			{
				Console.WriteLine(x.resultToLog());
			});
		}

		private void log(bool testResult, string name)
		{
			results.Add(new TestResult(testResult, name));
		}
	}

	class TestResult
	{
		public bool passed;
		public string name;

		public TestResult(bool passed, string name)
		{
			this.passed = passed;
			this.name = name;
		}

		public string resultToLog()
		{
			return "** " + this.name + " has " + (this.passed == true ? "passed" : "failed") + " the test.";
		}
	}
}
