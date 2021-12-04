using BigStarLib.Models;
using System;

namespace SimpleConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Some cards from our catalog!");

			var source = new CardSource();
			foreach (var card in source.CardsOrderedByName)
			{
				Console.WriteLine($"{card.SalePrice:C} : {card.Name}");
			}
		}
	}
}
