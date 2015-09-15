namespace LiskovSubstitutionPrinciple
{
  using System;

  public class Program
  {
    public static void Main(string[] args)
    {
      // case 1
      Console.WriteLine("Case1**************");
      RectangleCase1 rect = new RectangleCase1 { Height = 5, Width = 10 };
      Console.WriteLine("React Are: " + AreaCalculatorCase1.Area(rect));

      rect = new SquareCase1 { Height = 5, Width = 10 };
      Console.WriteLine("Square Are: " + AreaCalculatorCase1.Area(rect));

      Console.ReadKey();

      // case 2
      Console.WriteLine();
      Console.WriteLine("Case2**************");
      Shape shape = new RectangleCase2 { Height = 5, Width = 10 };
      Console.WriteLine("React Are: " + AreaCalculatorCase2.Area(shape));

      shape = new SquareCase2 { Side = 5 };
      Console.WriteLine("Square Are: " + AreaCalculatorCase2.Area(shape));

      Console.ReadKey();

      // case 3
      Console.WriteLine();
      Console.WriteLine("Case3**************");
      Shape3 shape3 = new RectangleCase3 { Height = 5, Width = 10 };
      Console.WriteLine("React Are: " + AreaCalculatorCase3.Area(shape3));

      shape3 = new SquareCase3 { Side = 5 };
      Console.WriteLine("Square Are: " + AreaCalculatorCase3.Area(shape3));

      Console.ReadKey();
    }
  }
}
