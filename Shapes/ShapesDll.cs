namespace Shapes
{
    static public class ShapesOperations
    {
        static public double CalculateShapeArea(IShape shape)
        {
            return shape.GetShapeArea();
        }
        static public bool IsRectangle(Triangle triangle)
        {
            return triangle.IsRectangle();
        }
    }
}

public interface IShape
{
    public double GetShapeArea();
}

public class Circle : IShape
{
    private double radius;
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Радиус не может быть меньше нуля");
            radius = value;
        }
    }
    public Circle(double _radius)
    {
        Radius = _radius;
    }
    public double GetShapeArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

public class Triangle : IShape
{
    private double a, b, c;

    public Triangle(double _a, double _b, double _c)
    {
        a = _a; b = _b; c = _c;
        if (a+b < c || b+c < a || a+c < b)
        {
            throw new ArgumentException("Сумма двух сторон не может быть меньше третьей стороны");
        }
    }
    
    public bool IsRectangle()
    {
        if (Math.Pow(a,2) == Math.Pow(b, 2) + Math.Pow(c, 2) || 
            Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) || 
            Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            return true;
        
        return false;
    }
    public double GetShapeArea()
    {
        var P = (a + b + c) / 2;
        return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
    }
}

