namespace StrategyPattern
{
  using System;

  public interface IFerry : ICrossRiver
  {
  }

  public class Ferry : IFerry
  {
    #region Implementation of ICrossRiver

    public void Cross()
    {
      Console.WriteLine("Sit in Farry and crossed river.");
    }

    #endregion
  }
}