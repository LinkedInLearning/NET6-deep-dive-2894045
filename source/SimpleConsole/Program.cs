// See https://aka.ms/new-console-template for more information


DoWork("hello", 5);
DoBetterWork("goodbye", 7);
// DoBetterWork(null, 7);


static void DoWork(string message, int count) {
	if (message is null)
	{
		throw new ArgumentNullException(nameof(message));
	}

	for (int counter = 0; counter < count; counter++)
	{
		Console.WriteLine(message);
	}
}

static void DoBetterWork(string message, int count) {
	ArgumentNullException.ThrowIfNull(message);
	// ArgumentNullException.ThrowIfNull(message);

	for (int counter = 0; counter < count; counter++)
	{
		Console.WriteLine(message);
	}
}



