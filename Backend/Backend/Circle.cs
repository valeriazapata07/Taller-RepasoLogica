
namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get
        {
            return _r;
        }
        set
        {
            _r = ValidateR(value);
        }
    }

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    private double ValidateR(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("El radio (R) debe ser mayor que cero.");
        }

        return value;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }
}
