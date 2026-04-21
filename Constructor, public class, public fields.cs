//import like python...
using system;
//Public Class
public class Star
{
  //public fields
    public string name;
    public string type;
    public int age;
    public double brightness;

//Constructor
public static Star(string name, string type)
{
  Name = name;
  Type = type;
  Age = 0;
  brightness = 1.0;
}
//Second Constructor
public static Star(String name) : this(name, "type Unknown")
{
  Console.WriteLine("Star type set to default: Unknown");
}
//Method to display star information
public void DisplayInfo()
{  Console.WriteLine($"Star Name: {Name}");
  Console.WriteLine($"Star Type: {Type}");
  Console.WriteLine($"Star Age: {Age} million years");
  Console.WriteLine($"Star Brightness: {Brightness} times that of the Sun");
}
 public void Shine(string NAME, double BRIGHTNESS)
  {
    name = NAME;
    brightness = BRIGHTNESS;
    //($) is used for string interpolation in C# like (f) string on python
    Console.WriteLine($"Star {NAME} is shining with brightness{BRIGHTNESS}");
  }
  public static Supernova(int brightness)
  {
    brightness = 0;
  }
}


