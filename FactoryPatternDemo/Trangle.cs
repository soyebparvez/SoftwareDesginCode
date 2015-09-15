namespace FactoryPatternDemo
{
  public class Trangle : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Trangle";
    }

    #endregion
  }
}