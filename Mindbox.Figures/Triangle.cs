namespace Mindbox.Figures;

public class Triangle : Shapes
{
    private readonly float[] _sides;
    private readonly float[]? _legs;
    private float? _cachedSquareResult;
    public bool IsRightTriangle => _legs != null;

    public Triangle(float a, float b, float c)
    {
        _sides = new[] { a, b, c };

        if (_sides.Any(side => side < 0))
            throw new ArgumentException("Sides must be greater than or equal to 0");

        var hypotenuse = _sides.Max();
        _legs = _sides.Order().Take(2).ToArray();

        if (_legs.Sum() < hypotenuse)
            throw new ArgumentException("No triangle exists with such legs");

        var isRightTriangle =
            MathF.Pow(hypotenuse, 2) - (MathF.Pow(_legs[0], 2) + MathF.Pow(_legs[1], 2))
                is < 1e-6f and > -1e-6f;

        _legs = isRightTriangle ? _legs : null;
    }

    public override float Square()
    {
        if (_cachedSquareResult != null)
            return _cachedSquareResult.Value;

        if (IsRightTriangle)
        {
            _cachedSquareResult = _legs![0] * _legs[1] / 2;
            return _cachedSquareResult.Value;
        }

        var semiPerimeter = Perimeter() / 2;
        _cachedSquareResult = MathF.Sqrt(semiPerimeter
                                   * (semiPerimeter - _sides[0])
                                   * (semiPerimeter - _sides[1])
                                   * (semiPerimeter - _sides[2]));

        return _cachedSquareResult.Value;
    }

    public override float Perimeter() => _sides.Sum();
}