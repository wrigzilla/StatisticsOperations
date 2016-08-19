using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatisticsOperationsUnitTests.TestManager;

namespace StatisticsOperationsUnitTests
{
	class Program
	{
		static void Main(string[] args)
		{
			TestManager.TestManager tests = new TestManager.TestManager();
			tests.runTests();

		}
	}
}
