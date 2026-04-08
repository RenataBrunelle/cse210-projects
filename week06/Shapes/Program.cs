using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Pink", 3);
        shapes.Add(s1);

        Circle s2 = new Circle("Yellow", 4);
        shapes.Add(s2);

        Rectangle s3 = new Rectangle("Blue", 4,3);
        shapes.Add(s3);
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape  has an area of {area}.");
        }
    }
}