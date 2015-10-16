namespace BridgePattern
{
  using System;

  public interface INearRiver : ILive
  {
  }

  public class NearRiver : INearRiver
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