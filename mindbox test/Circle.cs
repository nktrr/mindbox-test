namespace mindbox_test;

public class Circle : ICircle
{
    public Circle(double r)
    {
        R = r;
    }
    
    // считается, что радиус может быть отрицательным
    public double CalculateArea()
    {
        return Math.PI * R * R;
    }

    public double R { get; }
}