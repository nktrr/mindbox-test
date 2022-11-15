namespace mindbox_test;

public class Triangle : IPolygon
{
    public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
    {
        XPoints = new double[3] {x1, x2, x3};
        YPoints = new double[3] {y1, y2, y3};
    }


    public double[] XPoints { get; }
    public double[] YPoints { get; }

    // формула Герона
    public double CalculateArea()
    {
        double a = Math.Sqrt(Math.Pow(XPoints[0] - XPoints[1], 2) + Math.Pow(YPoints[0] - YPoints[1], 2));
        double b = Math.Sqrt(Math.Pow(XPoints[0] - XPoints[2], 2) + Math.Pow(YPoints[0] - YPoints[2], 2));
        double c = Math.Sqrt(Math.Pow(XPoints[1] - XPoints[2], 2) + Math.Pow(YPoints[1] - YPoints[2], 2));
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }
    
}