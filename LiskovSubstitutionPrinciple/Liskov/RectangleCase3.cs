using System;

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

  public class AreaCalculatorExecution3
  {
    public static void Main(string[] args)
    {
      // case 3
      Console.WriteLine();
      Console.WriteLine("Case3**************");
      Console.ForegroundColor = ConsoleColor.Yellow;

      Shape3 shape3 = new RectangleCase3 { Height = 5, Width = 10 };
      Console.WriteLine("React Are: " + AreaCalculatorCase3.Area(shape3));

      shape3 = new SquareCase3 { Side = 5 };
      Console.WriteLine("Square Are: " + AreaCalculatorCase3.Area(shape3));

      Console.ResetColor();
      Console.ReadKey();
    }
  }
}