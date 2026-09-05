
namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    private double _b;

    public double B
    {
        get
        {
            return _b;
        }
        set
        {
            _b = ValidateB(value);
        }
    }

    public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    private double ValidateB(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El lado (B) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}