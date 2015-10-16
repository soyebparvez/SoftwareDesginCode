namespace BridgePattern
{
  using System;

  public interface IInCity : ILive
  {
  }

  public class InCity : IInCity
  {
    #region Implementation of ILive

    public void Swim(ISwim swim)
    {
      Console.WriteLine("Person lives " + this.GetType().Name + " swim in " + swim.GetType().Name);
      swim.Swim();
    }

    #endregion
  }
}