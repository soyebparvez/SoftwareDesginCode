namespace StrategyPattern
{
  using System;

  public class Villager : IVillager
  {
    #region Implementation of IVillager

    public void CrossRiver(ICrossRiver crossRiver)
    {
      Console.WriteLine(this.GetType().Name + " crossed river by " + crossRiver.GetType().Name);
      crossRiver.Cross();
    }

    #endregion
  }
}