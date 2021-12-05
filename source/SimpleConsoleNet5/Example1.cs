using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples
{
	internal class Example1
	{
		internal void InferTypeFromLambda()
		{
			var showMessage = (int x, int y) => Console.WriteLine(x + y);
		}
	}

	}
