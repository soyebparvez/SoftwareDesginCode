namespace StrategyPattern
{
  using System;

  public class Program
  {
    public static void Main(string[] args)
    {
      IVillager villager = new Villager();
      villager.CrossRiver(new Bridge());
      Console.ReadKey();
    }
  }
}
