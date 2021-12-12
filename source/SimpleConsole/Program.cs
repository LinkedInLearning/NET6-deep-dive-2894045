// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SimpleConsole;
class Program
{

  static async Task Main() {
		var d = new Demo();
		while (true)
		{
			d.ShowLoadingPrompt();
		}
	}
	internal class Demo {
		internal void ShowLoadingPrompt() {
			Console.Title = Environment.ProcessId.ToString();
			Console.Write(".");
			Task.Delay(600).Wait();
		}
	}
}



