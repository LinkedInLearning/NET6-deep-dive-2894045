using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.Examples

{
	internal class Example4
	{

		 void WithStringBuilder()
		{
			int dice1 = 3; int dice2 = 2;
			var s1 = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";
			var builder = new StringBuilder();
			builder.Append("Dice results: ");
			builder.Append($"{dice1} and {dice2}. ");
			builder.Append($"Total = {dice1 + dice2}");
		}
	}
}
