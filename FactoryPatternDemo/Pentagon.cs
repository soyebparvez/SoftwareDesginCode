namespace FactoryPatternDemo
{
  public class Pentagon : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Pentagon";
    }

    #endregion
  }
}