namespace LiskovSubstitutionPrinciple
{
  public abstract class Shape
  {
  }

  public class RectangleCase2 : Shape
  {
    public int Height { get; set; }
    public int Width { get; set; }
    public int Area()
    {
      return Height * Width;
    }
  }

  public class SquareCase2 : Shape
  {
    public int Side { get; set; }
    public int Area()
    {
      return Side * Side;
    }
  }

  public class AreaCalculatorCase2
  {
    public static int Area(Shape shape)
    {
      if (shape == null)
      {
        return 0;
      }

      if (shape is RectangleCase2)
      {
        return ((RectangleCase2)shape).Area();
      }

      if (shape is SquareCase2)
      {
        return ((SquareCase2)shape).Area();
      }

      return 0;
    }
  }
}