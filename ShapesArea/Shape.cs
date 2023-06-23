namespace ShapesArea;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2.0;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightAngled()
    {
        var sides = new[] {SideA, SideB, SideC};
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.000001;
    }
}



public class Rectangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override double CalculateArea()
    {
        return SideA * SideB;
    }
}