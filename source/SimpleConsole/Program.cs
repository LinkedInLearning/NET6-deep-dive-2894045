// See https://aka.ms/new-console-template for more information
namespace SimpleConsole;
class Program {
	static int counter = 0;
	static System.Threading.Timer _timer;
	static Random _ran = Random.Shared;
	static async Task Main() {
		Example1();

		// await Example2();
		Console.WriteLine("Waiting in Main.");
		Console.ReadLine();
	}

	static void Example1() {
		// five existing timers!
		// System.Timers.Timer (multi-thread)
		// System.Threading.Timer (multi-thread)
		// System.Windows.Threading.DispatcherTimer (single-thread)
		// System.Windows.Forms.Timer (single-thread)
		// System.Web.UI.Timer
		Console.WriteLine("Threading.Timer (with callback)");
		_timer = new Timer(DoWorKCallback, null, 0, 1000);

	}

	static async void DoWorKCallback(object? _) {
		// problems occur with overlap (w
		counter += 1;
		var time = (TimeOnly.FromDateTime(DateTime.Now)).ToLongTimeString();
		var delaySpan = _ran.Next(500, 600);
		int threadId = Environment.CurrentManagedThreadId;
		Console.WriteLine($"Tick ({time}), Delay {delaySpan}");
		Console.WriteLine($"   First... [{threadId}]");

		await Task.Delay(delaySpan);
		Console.WriteLine($"    Second...[{threadId}]\n");

		if (counter > 4)
		{
			_timer.Change(Timeout.Infinite, Timeout.Infinite);
		}
	}

	async static Task Example2() {
		// PeriodicTimer class
		// waits asynchronously for timer ticks.
		// accepts a cancellation token

		// useful for avoiding callbacks.
		// avoids overlap problems, 
		// no need for Auto-reset event or other thread synchronization 

		Console.WriteLine("PeriodicTimer");

		var waitSpan = TimeSpan.FromSeconds(1);
		var timer = new PeriodicTimer(waitSpan);
		var counter = 0;
		// use an await between each tick
		// Waits for the next tick of the timer, or for the timer to be stopped.
		while (await timer.WaitForNextTickAsync())
		{
			// scenario, we want to run timer every 1 second
			// the work occasionally runs longer than that.
			// awaiting the timer accommodates this issue.

			// no need for callback
			counter += 1;
			var time = (TimeOnly.FromDateTime(DateTime.Now)).ToLongTimeString();
			var delaySpan = _ran.Next(500, 2200);
			int threadId = Environment.CurrentManagedThreadId;
			Console.WriteLine($"Tick ({time}), Delay {delaySpan}");
			Console.WriteLine($"   First... [{threadId}]");

			await Task.Delay(delaySpan);
			Console.WriteLine($"    Second...[{threadId}]\n");
			if (counter > 4)
			{
				return;
			}

		}

	}

}







