using System;

namespace BridgePattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ILive live = new NearRiver();
      live.Swim(new River());

      var live2 = new NearSea();
      live2.Swim(new Sea());

      var live3 = new InCity();
      live3.Swim(new Pool());

      Console.ReadKey();
    }
  }
}
