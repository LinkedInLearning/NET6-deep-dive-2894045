using System;

namespace SimpleConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// detailed explanation at
			// https://devblogs.microsoft.com/dotnet/string-interpolation-in-c-10-and-net-6/

			// C# compiler rewrites string interpolation in different ways
			// // depending on the context.

			const string w1 = "Please sign into your account";
			const string w2 = "Marcus";

			var literalized = $"{w1} {w2}"; // compiler knows these strings are literals

			string pizza1 = "Pepperoni Pizza"; // variable, not literal constant
			string pizza2 = "Veggie Pizza";


			var concatenized = $"Your order of {pizza1} and {pizza2} is ready.";

			//var concat2 = String.Concat();
			int x = 5; int y = 7;
			var s1 = $"Your numbers are {x} and {y}";

			// compiler changes to:
			
			var s2 = String.Format("Your number are {0} and {1}", x, y);
			// this causes value type boxing and other performance concerns! 
			Console.WriteLine(s1);
			;
			NewInterpolation();
		}
		public static void NewInterpolation()
		{
			int dice1 = 3; int dice2 = 72;
			var message = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";

		}
	}
}
