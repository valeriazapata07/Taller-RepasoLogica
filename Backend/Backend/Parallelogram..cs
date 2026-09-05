
namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    private double _h;

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

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
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
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}
