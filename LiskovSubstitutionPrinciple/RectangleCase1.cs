using System;

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

  public class AreaCalculatorExecution1
  {
    public static void Main(string[] args)
    {
      // case 1
      Console.WriteLine("Case1**************");
      RectangleCase1 rect = new RectangleCase1 {Height = 5, Width = 10};
      Console.WriteLine("React Are: " + AreaCalculatorCase1.Area(rect));

      rect = new SquareCase1 {Height = 5, Width = 10};
      Console.WriteLine("Square Are: " + AreaCalculatorCase1.Area(rect));

      Console.ReadKey();
    }
  }
}