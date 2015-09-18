namespace LiskovSubstitutionPrinciple
{
  using System;

  public class PistonEngine
  {
  }

  public class Car
  {
    public Car()
    {
      this.Engine = new PistonEngine();
    }

    public PistonEngine Engine { get; private set; }
  }

  public class OpenClosePExecuter
  {
    public static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Car car = new Car();
      Console.WriteLine("Car has " + car.Engine.GetType().Name);
      Console.WriteLine("What happen when we want to change car Engine. we have to modify car class");
      Console.WriteLine("This design is not close for modification.");
      Console.WriteLine("Now we invert dependency in extended car.");

      Console.ResetColor();
      Console.ReadKey();
    }
  }
}