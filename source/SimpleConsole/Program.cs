// See https://aka.ms/new-console-template for more information
namespace SimpleConsole;
class Program
{
  static void Main()
  {
    Example1();
    Example2();
    //Example3();

  }
  static void Example1()
  {
    Console.WriteLine("Example 1 - Priority Queue");
    // a new class PriorityQueue
    // assign a priority level when added to the queue.
    // specify a priority type when creating the PriorityQueue
    // highest priority (determined by the types Comparer) items are removed first

    // note: is not thread-safe
    // note, cannot change priority of item is enqueued.
    // note: Is not "stable", no guarantee
    // that two items with same priority are removed in original order 

    var foodQueue = new PriorityQueue<string, int>();

    foodQueue.Enqueue("apple", 9);
    foodQueue.Enqueue("banana", 5);
    foodQueue.Enqueue("cherry", 5);
    foodQueue.Enqueue("durian", 4);
    foodQueue.Enqueue("eggplant", 9);

    // cannot enumerate it with a loop 
    // foreach(var food in foodQueue) 
    while (foodQueue.TryDequeue(out var food, out var level)) {
      Console.WriteLine($"{food}, {level}");
    }


  }
  static void Example2()
  {
    Console.WriteLine("Example 2 - Set capacity");


    // Call EnsureCapacity() before inserting large set of data into collections
    // This allows the collection to determine memory size early.
    // Avoids resizing internal memory as items are added.

    var myList = new List<int>();
    var myStack = new Stack<int>();
    var myQueue = new Queue<int>();
    var myList2 = new List<int>(capacity:300);

 
    myList.EnsureCapacity(500);
    myStack.EnsureCapacity(500);
    myQueue.EnsureCapacity(500);

    // dictionaries and hashset already had this method

    var myHashSet = new HashSet<int>();
    myHashSet.EnsureCapacity(500);

    

  }






}







