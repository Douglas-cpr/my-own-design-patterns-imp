using AbstractFactory.Factories;

namespace AbstractFactory;
public static class Application
{
  public static void Main(string[] args) {
    var humanFactory = new HumanFactory();

    Console.WriteLine("Creating a human");
    humanFactory.CreateArms();
    humanFactory.CreateLegs();
    Console.WriteLine("Created a human");

    var monkeyFactory = new MonkeyFactory();
    Console.WriteLine("Creating a monkey");
    monkeyFactory.CreateArms();
    monkeyFactory.CreateArms();
    Console.WriteLine("Created a monkey");
  }
}
