namespace BridgePattern
{
  using System;

  public interface IRiver : ISwim
  {
  }

  public class River : IRiver
  {
    #region Implementation of ISwim

    public void Swim()
    {
      Console.WriteLine("It is my necessity to swim in river to go in city.");
    }

    #endregion
  }
}