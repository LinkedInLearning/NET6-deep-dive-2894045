// See https://aka.ms/new-console-template for more information
using System.Text.Json;

namespace SimpleConsole;
class Program
{

  static async Task Main()
  {

    Food? food;
    food = new Food { FoodName = "banana", Calories = 130 };

    var x = new FoodGenerationContext();
    byte[] utf8Json = JsonSerializer.SerializeToUtf8Bytes( food,
                                                         FoodGenerationContext.Default.Food);


    Console.WriteLine(utf8Json);
    var stringJson = JsonSerializer.Serialize( food,FoodGenerationContext.Default.Food);

    Console.WriteLine(stringJson);

    var foodAgain = JsonSerializer.Deserialize(stringJson, FoodGenerationContext.Default.Food);




  }



}



