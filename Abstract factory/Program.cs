using System;

namespace Abstract_factory
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Create and run the African animal world
      ContinentFactory africa = new AfricaFactory();

      AnimalWorld world = new AnimalWorld(africa);

      world.RunFoodChain();

      // Create and run the American animal world
      ContinentFactory america = new AmericaFactory();

      world = new AnimalWorld(america);

      world.RunFoodChain();

      // Wait for user input
      Console.ReadKey();
    }
  }
}
