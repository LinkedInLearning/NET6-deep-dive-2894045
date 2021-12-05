using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples
{
	internal class Example2
	{
		internal void DemoStringConcat()
		{
			string pizza1 = "Pepperoni Pizza"; // variable, not literal constant
			string pizza2 = "Veggie Pizza";


			var message = $"Your order of {pizza1} and {pizza2} is ready.";
		}
	}
}
