using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square square = new Square("Purple", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", 5, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 8);
        shapes.Add(circle);

        foreach (Shape s in shapes){
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"Color: {color} \nArea: {area}");
        }
    }
}