namespace BridgePattern
{
  using System;

  public interface IPool : ISwim
  {
  }

  public class Pool : IPool
  {
    #region Implementation of ISwim

    public void Swim()
    {
      Console.WriteLine("It is very nice to swim in pool.");
    }

    #endregion
  }
}