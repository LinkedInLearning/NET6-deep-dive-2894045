using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleConsole
{
  public class Food
  {
  
    public int Calories { get; set; }
    public string? FoodName { get; set; }
  }


  [JsonSerializable(typeof(Food))]

  [JsonSourceGenerationOptions(WriteIndented = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
  internal partial class FoodGenerationContext : JsonSerializerContext
  {
  }

}
