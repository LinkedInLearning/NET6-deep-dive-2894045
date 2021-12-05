using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples
{
	internal class Example1
	{
		internal void DemoStringLiteral()
		{
			const string w1 = "Please sign into your account";
			const string w2 = "Marcus";

			var message = $"{w1} {w2}"; // compiler knows these strings are literals
		}
	}

	}
