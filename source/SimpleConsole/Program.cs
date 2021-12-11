// See https://aka.ms/new-console-template for more information
using System.Text.Json;

namespace SimpleConsole;
class Program
{

  static async Task Main()
  {

   List<Food> foods=new List<Food>();
   foods.Add (new Food { FoodName = "banana", Calories = 130, Category= "Fruit" });
    foods.Add (new Food { FoodName = "fig", Calories = 245, Category = "Fruit" });

    var x = new FoodGenerationContext();
    byte[] utf8Json = JsonSerializer.SerializeToUtf8Bytes( foods[0],                                                         FoodGenerationContext.Default.Food);


    Console.WriteLine(utf8Json);
    var stringFood = JsonSerializer.Serialize( foods[1],
                                              FoodGenerationContext.Default.Food);

    Console.WriteLine(stringFood);

    var foodAgain = JsonSerializer.Deserialize(stringFood, FoodGenerationContext.Default.Food);

    var stringFoods = JsonSerializer.Serialize(foods,
                                               FoodsGenerationContext.Default);


  }



}



