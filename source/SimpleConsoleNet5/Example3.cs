using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples
{
	internal class Example3
	{
		internal void DemoStringFormat()
		{
			//var concat2 = String.Concat();
			int dice1 = 3; int dice2 = 2;
			var message = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";

			// compiler changes to:

			// var message = String.Format("Your number are {0} and {1}", x, y);
			// this causes value type boxing and other performance concerns! 
			
		}
	}
}
