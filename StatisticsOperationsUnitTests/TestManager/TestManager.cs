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

		public TestManager()
		{

		}

		private void runTests()
		{
			math = new MathOperationsTests();
		}
	}
}
