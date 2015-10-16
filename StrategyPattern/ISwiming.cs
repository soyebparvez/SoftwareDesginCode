namespace StrategyPattern
{
  using System;

  public interface ISwiming : ICrossRiver
  {
  }

  public class Swiming : ISwiming
  {
    #region Implementation of ICrossRiver

    public void Cross()
    {
      Console.WriteLine("I know swiming and crossed river.");
    }

    #endregion
  }
}