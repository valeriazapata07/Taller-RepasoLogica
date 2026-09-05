
namespace GeometricFigures.Backend;

public class Rectangle : Square
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

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    protected double ValidateB(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El lado (B) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}