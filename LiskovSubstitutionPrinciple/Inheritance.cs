using System;

namespace LiskovSubstitutionPrinciple
{
  public interface IAnimal
  {
  }

  public class Lion : IAnimal
  {
   
  }

  public interface IHuman : IAnimal
  {
    string Age { get; set; }
    string Gender { get; set; }
  }

  public class Human : IHuman
  {
    #region Implementation of IHuman

    public string Age { get; set; }
    public string Gender { get; set; }

    #endregion
  }

  public class KnowYourSelf
  {
    public void Discribe(IAnimal animal)
    {
      Console.WriteLine(animal.GetType().Name + " is " + typeof(IAnimal).Name);
    }
  }

  public class KnowYourSelfExecution1
  {
    public static void Main(string[] args)
    {
      KnowYourSelf knowYourSelf = new KnowYourSelf();
      knowYourSelf.Discribe(new Lion());
      knowYourSelf.Discribe(new Human());
      Console.ReadKey();
    }
  }
}