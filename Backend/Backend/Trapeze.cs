
namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get
        {
            return _d;
        }
        set
        {
            _d = ValidateD(value);
        }
    }

    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    private double ValidateD(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El lado (D) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return (B + D) * H / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
}