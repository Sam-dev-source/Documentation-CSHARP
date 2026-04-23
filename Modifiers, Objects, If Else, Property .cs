using System;

namespace AccessModifiers
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;
    private int treeCount;
  //Constructor with parameters
    public Forest(string name, string biome) 
    {
      this.name = name;
      this.biome = biome;
      age++;
      this.treeCount += 100; // Increment tree count by 100 for each new forest
    }
    //trees method with if-else statement and object instantiation
    static void Trees(bool isDense, int treeCount)
    {
      this.treeCount = treeCount;
      //If-Else statement to determine forest density, if else if statement is used to check if tree count is greater than 1000 for moderate density, else statement is used for not dense
      if (isDense)
      {
        Console.WriteLine($"The forest has {treeCount} trees and is dense.");
      }
      else if (treeCount > 1000)
      {
        Console.WriteLine($"The forest has {treeCount} trees and is moderately dense.");
      }
      else
      {
        //print statement with string interpolation is used to display the number of trees and the density status of the forest.
        Console.WriteLine($"The forest has {treeCount} trees and is not dense.");
      }
      //Object instantiation is used to create an instance of the Forest class, allowing us to work with the properties and methods of that instance.
      Forest f = new Forest("Enchanted Woods", "Temperate");
    }
    //Property with get and set accessors is used to encapsulate the name field, allowing controlled access to it. The get accessor retrieves the value of the name field, while the set accessor allows you to assign a new value to it.
    public string Name
      {
        get { return Name;}
        set { Name = value;}
      }
  }
}