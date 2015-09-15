namespace FactoryPatternDemo
{
  public class Circle:IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Circle";
    }

    #endregion
  }
}