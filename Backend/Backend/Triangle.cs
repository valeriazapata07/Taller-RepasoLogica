
namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C
    {
        get
        {
            return _c;
        }
        set
        {
            _c = ValidateC(value);
        }
    }

    public double H
    {
        get
        {
            return _h;
        }
        set
        {
            _h = ValidateH(value);
        }
    }

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    private double ValidateC(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El lado (C) debe ser mayor que cero.");
        }

        return value;
    }

    private double ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("La altura (H) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }
}