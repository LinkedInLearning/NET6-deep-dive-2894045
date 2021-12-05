using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples {
	internal class Example1 {
		internal static void InferTypeFromLambda() {

			Action<int,int> printMessage1 = (int x, int y) => Console.WriteLine(x + y);

			printMessage1(3, 4);

			//	var printMessage2 = s => Console.WriteLine("Hello");

			
			// can also infer the return type
			
			var getTotal = (float a, float b) => a + b;

			Console.WriteLine(getTotal(12.1f, 14.2f));

		}
	}
}
