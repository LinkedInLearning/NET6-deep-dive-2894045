// See https://aka.ms/new-console-template for more information
namespace SimpleConsole;
class Program
{
  static async Task Main()
  {
     //Example1();
   Example2();
    // await Example3();
    Console.WriteLine("Waiting in Main.");
    Console.ReadLine();
  }
  static void Example1()
  {
    // Parallel class was added to .NET before the the async features were added (await, asnyc keywords)
    // therefore it didn't have async support.
    // other NuGet package had implementations.
   
    var numbers = Enumerable.Range(11, 20);
    Console.WriteLine("Starting...");
    ParallelOptions options = new()
    {
      // limit the number of tasks with ParallelOptions
      MaxDegreeOfParallelism = 4
    };
    // note.  Parallel.ForEach is a synchronous method.
    // The work in ForEach k blocks until all tasks are complete
    //

    var result = Parallel.ForEach(source: numbers, parallelOptions: options, body: (num) =>
     {
       // a task is assigned for each item in source collection
       // each task runs it's delegate synchronously to perform the action
  


       // provide a thread safe Random instance
       var ran = Random.Shared;
       Task.Delay(ran.Next(200, 700)).Wait();

       Console.WriteLine($"ThreadID: \t{System.Environment.CurrentManagedThreadId:D2} \t {num}");


     });
 
    Console.WriteLine("Done in Example 1!");

  }
  static void Example2()
  {


    var numbers = Enumerable.Range(11, 20);
    Console.WriteLine("Starting...");
    ParallelOptions options = new()
    {
      MaxDegreeOfParallelism = 4
    };
    // note.  Parallel.ForEachAsync is a synchronous method
    // work blocks until all tasks are complete
    //

    Parallel.ForEachAsync(source: numbers, parallelOptions: options, body: async (num, token) =>
    {
      // a task is assigned for each item in source collection
      // each task runs it's delegate synchronously to perform the action

      // limit the number of tasks with ParallelOptions

      // provide a thread safe Random instance
      var ran = Random.Shared;



      Task.Delay(ran.Next(200, 700)).Wait();

      Console.WriteLine($"ThreadID: \t{System.Environment.CurrentManagedThreadId:D2} \t {num}");


    });

    Console.WriteLine("Done in Example2");
  }

  async static Task Example3()
  {
    // multiple timers in .NET
    // System.Timers.Timer
    // System.Threading.Timer
    // System.Web.UI.Timer
    // System.Windows.Threading.DispatcherTimer
    // System.Windows.Forms.Timer


    // new PeriodicTimer class
    // waits synchronously for timer ticks.
    // accepts a cancellation token

    // useful for avoiding callbacks.

    var ran = Random.Shared;

    var waitSpan = TimeSpan.FromSeconds(1);
    var timer = new PeriodicTimer(waitSpan);

    // use an await between each tick
    while (await timer.WaitForNextTickAsync())
    {
      // scenario, we want to run timer every 1 second
      // work ocassionally runs longer than that.
      // awaiting time accomodates this issue.

      var delaySpan = ran.Next(500, 2500);
      await Task.Delay(delaySpan);
      Console.WriteLine($"Tick {DateTime.Now}, Delay {delaySpan}");
    }

  }




}







