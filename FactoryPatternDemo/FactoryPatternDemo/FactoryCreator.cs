namespace FactoryPatternDemo
{
  public interface IShapeCreator
  {
    IShape CreateShape(ShapeType shapeType);
  }

  public class ShapeCreator:IShapeCreator
  {

    #region IShapeCreator Members

    public IShape CreateShape(ShapeType shapeType)
    {
      IShape shape = null;
      switch(shapeType)
      {
        case ShapeType.Circle:
          shape = new Circle();
          break;
        case ShapeType.Squire:
          shape = new Squire();
          break;
        case ShapeType.Trangle:
          shape = new Trangle();
          break;
        case ShapeType.Pentagon:
          shape = new Pentagon();
          break;
      }
      return shape;
    }

    #endregion
  }
  /*
  public class FactoryCreator
  {
    public static IShape Create(ShapeType shapeType)
    {
      IShape shape = null;
      switch (shapeType)
      {
        case ShapeType.Circle:
          shape = new Circle();
          break;
        case ShapeType.Squire:
          shape = new Squire();
          break;
        case ShapeType.Trangle:
          shape = new Trangle();
          break;
      }
      return shape;
    }
  }
   */
}
