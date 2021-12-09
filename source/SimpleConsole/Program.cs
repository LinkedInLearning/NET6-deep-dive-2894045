// See https://aka.ms/new-console-template for more information
namespace SimpleConsole;
class Program
{
  static void Main()
  {
    //Example1();
    //Example2();
    Example3();

  }
  static void Example1()
  {

    // The *OrDefault operator
    // Returns the first element of a sequence,
    // or a default value if the sequence contains no elements.
    IEnumerable<int> numbers = Enumerable.Range(101, 150);
    IEnumerable<int> empty = new List<int>();

    // .NET 6 improvement,
    // set your own default value for SingleOrDefault, FirstOrDefault and LastOrDefault

    var f1 = numbers.FirstOrDefault();

    var f2 = empty.FirstOrDefault();

    var f3 = empty.FirstOrDefault(defaultValue: 20);
    Console.WriteLine();
  }

  static void Example2()
  {
    // break a sequence into batches with the .Chunk method

    var numbers = Enumerable.Range( start: 11, count: 20);
    var chunkSize = 5;

    IEnumerable<int[]> subset = numbers.Chunk(chunkSize);

      Parallel.ForEach(subset, (s) =>
      {
        // provide a thread safe Random instance
        var ran = Random.Shared;

        foreach (int numb in s)
        {
          var spacer = new string(' ', System.Environment.CurrentManagedThreadId % 4);
          Task.Delay(ran.Next(200,700)).Wait();
         
          Console.WriteLine($"{spacer}ThreadID: \t{System.Environment.CurrentManagedThreadId:D2} \t {numb}");
        }

      });



  }

  static void Example3()
  {
    
    var lowers = new List<string> { "a", "b", "c" };
    var uppers = new List<string> { "A", "B", "C" };
    var numbers = new List<int> { 1, 2, 3, 4, 5 };


    // creates a sequence of tuples
    //.NET 6 adds a third source.
    var zipped1 = lowers.Zip(numbers, uppers);

    Console.WriteLine("Zipped1");
    var zipped2 = numbers.Zip(lowers, uppers);

    foreach (var item in zipped1)
    {
      Console.WriteLine(item);
    }
    Console.WriteLine("Zipped1");
    foreach (var item in zipped2)
    {
      Console.WriteLine(item);
    }

  }

  public record Food
  {
    public Food(string foodName)
    {
      FoodName = foodName;
     
    }
    public Food(string foodName, int calories)
    {
      FoodName = foodName;
      Calories = calories;
    }
    public string FoodName { get; set; }
    public int Calories { get; set; }
  }
 

  public class FoodSource
  {
    private List<Food> _foods;
    private List<Food> _allergies;
    public FoodSource()
    {
      _foods = new List<Food>();
      _allergies = new List<Food>();
      _foods.Add(new Food("apple", 200));
      _foods.Add(new Food("banana" , 160));
      _foods.Add(new Food("bread" , 400));
      _allergies.Add(new Food("bread", 0));
      _foods.Add(new Food("cherry", 180));

     
    
      _allergies.Add(new Food("pizza"));

    }
    public List<Food> AllFoods
    {
      get
      {
        return _foods;
      }
    }
    public List<Food> MyAllergies
    {
      get
      {
        return _allergies;
      }
    }


  }
}







