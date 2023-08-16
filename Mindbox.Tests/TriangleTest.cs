using Mindbox.Figures;

namespace Mindbox.Tests;

public class TriangleTest
{
    [Fact]
    public void Square_WithValidSides()
    {
        Shapes triangle = new Triangle(5, 8, 6);
        Assert.InRange(triangle.Square(), 14.98f, 14.99f);
    }

    [Fact]
    public void Create_WithImpossibleSides()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(5, 12, 6));
    }
    
    [Fact]
    public void Create_WithNegativeSides()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-5, 12, 6));
    }

    [Fact]
    public void Square_WithZeroSides()
    {
        Shapes triangle = new Triangle(0, 0, 0);
        Assert.Equal(0, triangle.Square());
    }
    
    [Fact]
    public void Square_WithEqualSides()
    {
        Shapes triangle = new Triangle(3, 3, 3);
        Assert.InRange(triangle.Square(), 3.897f, 3.898f);
    }

    [Fact]
    public void Create_IsRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle);
    }
}