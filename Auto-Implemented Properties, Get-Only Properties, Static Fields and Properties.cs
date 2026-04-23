using System;

namespace AutoImplementedProperties
{
  class Forest
  {
    public string Name
// Auto- implemented Properties is a shorthand syntax for properties that do not require additional logic in the get or set accessors. The compiler automatically creates a private, anonymous backing field that can only be accessed through the property's get and set accessors.
      { get; set; }


    public int Trees
    
      { get; set;}
//get only properties are a special type of auto-implemented property that only have a get accessor. They are read-only properties that can be set only during object initialization or in the constructor.
    public int Age
    {
    get { return Age;}
    private set { Age = value;}
    }

    private string biome;
    public string Biome 
    {
      get {
        return biome;
      }
      set {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) {
          biome = value;
        }
        else {
          biome = "Unknown";
        }
      }
    }
  }
  //static fields and properties are shared among all instances of a class. They belong to the class itself rather than any specific instance. Static members can be accessed without creating an instance of the class.
  public static int ForestsCreated
      {
        get; private set;
      }

    // CONSTRUCTORS
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
  // Static method to display the total number of forests created
    public static void ForestCreated()
    {
      Console.WriteLine($"Total Forests Created: {ForestsCreated}");
    }

}