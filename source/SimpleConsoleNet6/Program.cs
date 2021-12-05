// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

NewInterpolation();

 static void NewInterpolation()
{
	int dice1 = 3; int dice2 = 72;
	var s1 = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";
}

static void WithStringBuilder()
{
	int dice1 = 3; int dice2 = 2;
	var s1 = $"Dice results: {dice1} and {dice2}.  Total = {dice1 + dice2}";
	var builder = new StringBuilder ();
	builder.Append("Dice results: ");
	builder.Append($"{dice1} and {dice2}. ");
	builder.Append($"Total = {dice1 + dice2}");
}