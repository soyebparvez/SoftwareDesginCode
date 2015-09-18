namespace LiskovSubstitutionPrinciple
{
  using System;

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

  public class DependencyInversionPExecuter
  {
    public static void Main(string[] args)
    {
      ExtendedCar car = new ExtendedCar(new ExtendedPistonEngine());
      Console.WriteLine("Car has " + car.Engine.GetType().Name);

      ExtendedCar car2 = new ExtendedCar(new ExtendedJetEngine());
      Console.WriteLine("Car has " + car2.Engine.GetType().Name);

      Console.WriteLine("Now This design is closed for modification.");
      Console.WriteLine("We are injecting engine from constructor.");
      Console.ReadKey();
    }
  }
}