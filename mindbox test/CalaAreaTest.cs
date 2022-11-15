using NUnit.Framework;

namespace mindbox_test.tests;

[TestFixture]
public class CalcAreaTest
{

    [Test]
    public void Calc_Triangle_Area_1()
    {
        var triangle = new Triangle(1, -2, -2, 1, 4, -2);
        var result = triangle.CalculateArea();
        Assert.AreEqual(9.0d, Math.Round(result));
    }

    // вырожденный треугольник
    [Test]
    public void Calc_Triangle_Area_2()
    {
        var triangle = new Triangle(0, 2, -2, 0, 0, 0);
        var result = triangle.CalculateArea();
        Assert.AreEqual(0.0d, Math.Round(result));
    }

    [Test]
    public void Calc_Triangle_Area_3()
    {
        var triangle = new Triangle(0, 4, 4, 0, 0, 8);
        var result = triangle.CalculateArea();
        Assert.AreEqual(16.0d, Math.Round(result));
    }

    [Test]
    public void Calc_Circle_Area_1()
    {
        var circe = new Circle(5.45);
        var result = circe.CalculateArea();
        Assert.AreEqual(93.313156, Math.Round(result,6));
    }
    
    [Test]
    public void Calc_Circle_Area_2()
    {
        var circe = new Circle(0);
        var result = circe.CalculateArea();
        Assert.AreEqual(0, 0);
    }
    
    [Test]
    public void Calc_Circle_Area_3()
    {
        var circe = new Circle(-1);
        var result = circe.CalculateArea();
        Assert.AreEqual(Math.PI, result);
    }
}