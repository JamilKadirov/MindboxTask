using Mindbox.Figures;

namespace Mindbox.Tests;

public class CircleTest
{
    [Fact]
    public void Square_WithValidRadius()
    {
        Shapes circle = new Circle(3);
        Assert.InRange(circle.Square(), 28.26f, 28.28f);
    }

    [Fact]
    public void Create_WithNegativeRadius()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void Square_WithZeroRadius()
    {
        Shapes circle = new Circle(0);
        Assert.Equal(0, circle.Square());
    }
}