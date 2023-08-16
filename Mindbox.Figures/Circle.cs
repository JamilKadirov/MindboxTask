namespace Mindbox.Figures;

public class Circle : Shapes
{
    private readonly float _radius;
    
    public Circle(float radius)
    {
        if (radius < 0)
            throw new ArgumentException("Incorrect radius", nameof(radius));
        
        _radius = radius;
    }
    
    public override float Square()
    {
        return MathF.PI * MathF.Pow(_radius, 2);
    }

    public override float Perimeter()
    {
        return 2 * MathF.PI * _radius;
    }
}