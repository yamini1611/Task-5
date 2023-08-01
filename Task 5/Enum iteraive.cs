using System;

public enum Shape
{
    Circle,
    Rectangle,
    Square
}

public class Areacalculator
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double CalculateSquareArea(double side)
    {
        return side * side;
    }

    public static void Main(string[] args)
    {
  
            foreach (Shape shape in Enum.GetValues(typeof(Shape)))
            {
                switch (shape)
                {
                    case Shape.Circle:
                        Console.WriteLine("Enter the radius:");
                        double circleRadius = double.Parse(Console.ReadLine());
                        double circleArea = CalculateCircleArea(circleRadius);
                        Console.WriteLine($"Circle Area: {circleArea}");
                        break;

                    case Shape.Rectangle:
                        Console.WriteLine("Enter the length:");
                        double rectangleLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width:");
                        double rectangleWidth = double.Parse(Console.ReadLine());
                        double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
                        Console.WriteLine($"Rectangle Area: {rectangleArea}");
                        break;

                    case Shape.Square:
                        Console.WriteLine("Enter the side length:");
                        double squareSide = double.Parse(Console.ReadLine());
                        double squareArea = CalculateSquareArea(squareSide);
                        Console.WriteLine($"Square Area: {squareArea}");
                        break;
                }
            }
            Console.ReadLine();

    }
}
