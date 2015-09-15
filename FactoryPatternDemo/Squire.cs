namespace FactoryPatternDemo
{
  public class Squire : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Squire";
    }

    #endregion
  }
}