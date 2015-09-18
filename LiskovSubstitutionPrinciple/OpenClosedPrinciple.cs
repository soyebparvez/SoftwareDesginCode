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

  public class CarExecuter
  {
    public static void Main(string[] args)
    {
      Car car = new Car();
      Console.WriteLine("Car has " + car.Engine.GetType().Name);
      Console.WriteLine("What happen when we want to change car Engine. we have to modify car class");
      Console.WriteLine("This design is not close for modification");
      Console.WriteLine("Now we invert dependency in extended car");
      Console.ReadKey();
    }
  }

  public interface IEngine
  {
  }

  public class ExtendedPistonEngine : IEngine
  {
  }

  public class ExtendedJetEngine : IEngine
  {
  }

  public class ExtendedCar
  {
    public ExtendedCar(IEngine engine)
    {
      this.Engine = engine;
    }

    public IEngine Engine { get; private set; }
  }

  public class ExtendedCarExecuter
  {
    public static void Main(string[] args)
    {
      ExtendedCar car = new ExtendedCar(new ExtendedPistonEngine());
      Console.WriteLine("Car has " + car.Engine.GetType().Name);

      ExtendedCar car2 = new ExtendedCar(new ExtendedJetEngine());
      Console.WriteLine("Car has " + car2.Engine.GetType().Name);

      Console.ReadKey();
    }
  }
}