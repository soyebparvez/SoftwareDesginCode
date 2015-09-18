using System;

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

  public class AreaCalculatorExecution2
  {
    public static void Main(string[] args)
    {
      // case 2
      Console.WriteLine();
      Console.WriteLine("Case2**************");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Shape shape = new RectangleCase2 { Height = 5, Width = 10 };
      Console.WriteLine("React Are: " + AreaCalculatorCase2.Area(shape));

      shape = new SquareCase2 { Side = 5 };
      Console.WriteLine("Square Are: " + AreaCalculatorCase2.Area(shape));

      Console.ResetColor();
      Console.ReadKey();
    }
  }
}