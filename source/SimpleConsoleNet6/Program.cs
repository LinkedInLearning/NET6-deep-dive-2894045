// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

NewInterpolation();

 static void NewInterpolation()
{
	int dice1 = 3; int dice2 = 72;
	var s1 = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";
}

