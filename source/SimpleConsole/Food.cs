using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleConsole
{
  public class Food {
    [JsonPropertyOrder(2)]
    public int Calories { get; set; }
    [JsonPropertyOrder(1)]
    public string? FoodName { get; set; }
    [JsonPropertyOrder(3)]
    public string? Category { get; set; }
  }


  [JsonSerializable(typeof(Food))]

  [JsonSourceGenerationOptions(WriteIndented = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
  internal partial class FoodGenerationContext : JsonSerializerContext
  {
  }

  [JsonSerializable(typeof(IEnumerable<Food>))]

  [JsonSourceGenerationOptions(WriteIndented = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
  internal partial class FoodsGenerationContext : JsonSerializerContext
  {
  }

}
