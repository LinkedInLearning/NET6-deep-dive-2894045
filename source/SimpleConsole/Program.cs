// See https://aka.ms/new-console-template for more information


PrintPrettyLine("*", 40);
PrintColorLine("~", 7, ConsoleColor.Yellow);
PrintColorLine(null, 7, ConsoleColor.Yellow);


static void PrintPrettyLine(string lineChars, int count) {
	if (lineChars is null)
	{
		throw new ArgumentNullException(nameof(lineChars));
	}

	for (int counter = 0; counter < count; counter++)
	{
		Console.Write(lineChars);
		Console.WriteLine();
	}
}

static void PrintColorLine(string lineChars, int count, ConsoleColor color) {
	ArgumentNullException.ThrowIfNull(lineChars);
	ArgumentNullException.ThrowIfNull(lineChars);

	for (int counter = 0; counter < count; counter++)
	{
		Console.Write(lineChars);
		Console.WriteLine();
	}
}



