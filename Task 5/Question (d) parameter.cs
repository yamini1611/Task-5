using System;

public enum ShapeType
{
    Circle,
    Rectangle,
    Square
}

public class ShapeCalculator
{
    public static double CalculateArea(ShapeType shapeType, double[] dimensions)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                double radius = dimensions[0];
                return Math.PI * radius * radius;

            case ShapeType.Rectangle:
                double length = dimensions[0];
                double width = dimensions[1];
                return length * width;

            case ShapeType.Square:
                double side = dimensions[0];
                return side * side;

            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the shape type (Circle, Rectangle, Square):");
        string inputShape = Console.ReadLine();
        ShapeType shapeType;

        if (Enum.TryParse(inputShape, true, out shapeType))
        {
            double[] dimensions;

            switch (shapeType)
            {
                case ShapeType.Circle:
                    dimensions = new double[1];
                    Console.WriteLine("Enter the radius:");
                    dimensions[0] = double.Parse(Console.ReadLine());
                    break;

                case ShapeType.Rectangle:
                    dimensions = new double[2];
                    Console.WriteLine("Enter the length:");
                    dimensions[0] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width:");
                    dimensions[1] = double.Parse(Console.ReadLine());
                    break;

                case ShapeType.Square:
                    dimensions = new double[1];
                    Console.WriteLine("Enter the side length:");
                    dimensions[0] = double.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid shape type.");
                    return;
            }

            double area = CalculateArea(shapeType, dimensions);
            Console.WriteLine($"Area of {shapeType}: {area}");
        }
        else
        {
            Console.WriteLine("Invalid shape type.");
        }
    }
}
