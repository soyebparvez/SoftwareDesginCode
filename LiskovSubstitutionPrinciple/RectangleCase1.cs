namespace LiskovSubstitutionPrinciple
{
  public class RectangleCase1
  {
    public virtual int Height { get; set; }
    public virtual int Width { get; set; }
  }

  public class SquareCase1 : RectangleCase1
  {
    public override int Height
    {
      get
      {
        return base.Height;
      }
      set
      {
        base.Height = value;
        base.Width = value;
      }
    }

    public override int Width
    {
      get
      {
        return base.Width;
      }
      set
      {
        base.Width = value;
        base.Height = value;
      }
    }
  }

  public class AreaCalculatorCase1
  {
    public static int Area(RectangleCase1 rect)
    {
      return rect.Height * rect.Width;
    }

    public static int Area(SquareCase1 rect)
    {
      return rect.Height * rect.Width;
    }
  }
}