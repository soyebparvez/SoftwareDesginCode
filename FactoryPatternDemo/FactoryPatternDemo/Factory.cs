
namespace FactoryPatternDemo
{
  public interface IShape
  {
    string GetShape();
  }

  public class Circle:IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Circle";
    }

    #endregion
  }

  public class Squire : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Squire";
    }

    #endregion
  }

  public class Trangle : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Trangle";
    }

    #endregion
  }

  public class Pentagon : IShape
  {
    #region IShape Members

    public string GetShape()
    {
      return "I am Pentagon";
    }

    #endregion
  }
  public enum ShapeType
  {
    Circle,
    Squire,
    Trangle,
    Pentagon
  }

}
