using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StasticsOperations.DataStrategies
{
	interface IDataStrategy
	{
		double process(int[] data);
	}
}
