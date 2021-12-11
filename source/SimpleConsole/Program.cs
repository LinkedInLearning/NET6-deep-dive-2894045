// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SimpleConsole;
class Program
{

  static async Task Main()
  {

    List<Food> foods = new List<Food>();
    foods.Add(new Food { FoodName = "banana", Calories = 130, Category = "Fruit" });
    foods.Add(new Food { FoodName = "fig", Calories = 245, Category = "Fruit" });

  
    byte[] utf8JsonArray = 
      JsonSerializer.SerializeToUtf8Bytes(foods[0],
                                          FoodGenerationContext.Default.Food);

    Console.WriteLine(utf8JsonArray);
    var stringFood = JsonSerializer.Serialize(foods[1],
                                              FoodGenerationContext.Default.Food);

    Console.WriteLine(stringFood);

    var foodAgain = JsonSerializer.Deserialize(stringFood, FoodGenerationContext.Default.Food);

    var stringFoods = JsonSerializer.Serialize(foods,
                                     FoodsGenerationContext.Default.IEnumerableFood);

    Console.WriteLine("Original JSON");
    Console.WriteLine(stringFoods);


    // use writeable DOM to modify a node
    var topNode = JsonNode.Parse(stringFoods);


    // The DOM lets you navigate to a subsection of a JSON payload
    // and deserialize a single value, a custom type, or an array.
    var foodNode = topNode[0];
    foodNode["foodName"] = "Eggplant";


    var modifiedFoods = JsonSerializer.Deserialize(topNode,
                                    FoodsGenerationContext.Default.IEnumerableFood);


    Console.WriteLine("Modified DOM");
    Console.WriteLine(topNode);


    Console.WriteLine((modifiedFoods.First()as Food).FoodName);
  }



}



