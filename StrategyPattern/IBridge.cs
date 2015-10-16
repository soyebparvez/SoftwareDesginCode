namespace StrategyPattern
{
  using System;

  public interface IBridge : ICrossRiver
  {
  }

  public class Bridge : IBridge
  {
    #region Implementation of ICrossRiver

    public void Cross()
    {
      Console.WriteLine("Walked on bridge.");
    }

    #endregion
  }
}