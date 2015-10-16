namespace BridgePattern
{
  using System;

  public interface ISea : ISwim
  {
  }

  public class Sea : ISea
  {
    #region Implementation of ISwim

    public void Swim()
    {
      Console.WriteLine("It is very hard to swim in sea.");
    }

    #endregion
  }
}