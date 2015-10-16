namespace BridgePattern
{
  using System;

  public interface INearSea : ILive
  {
  }

  public class NearSea : INearSea
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