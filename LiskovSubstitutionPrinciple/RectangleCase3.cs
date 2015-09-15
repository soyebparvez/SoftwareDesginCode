namespace LiskovSubstitutionPrinciple
{
  public abstract class Shape3
  {
    public abstract int Area();
  }

  public class RectangleCase3 : Shape3
  {
    public int Height { get; set; }
    public int Width { get; set; }

    #region Overrides of Shape3

    public override int Area()
    {
      return Height * Width;
    }

    #endregion
  }

  public class SquareCase3 : Shape3
  {
    public int Side { get; set; }
    public override int Area()
    {
      return Side * Side;
    }
  }

  public class AreaCalculatorCase3
  {
    public static int Area(Shape3 shape)
    {
      return shape.Area();
    }
  }
}