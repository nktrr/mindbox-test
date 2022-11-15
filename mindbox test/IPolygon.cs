namespace mindbox_test;

public interface IPolygon : IFigure
{
    public double[] XPoints { get; }
    public double[] YPoints { get; }
}