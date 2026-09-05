
namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get
        {
            return _a;
        }
        set
        {
            _a = ValidateA(value);
        }
    }

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    protected double ValidateA(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El lado (A) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
}