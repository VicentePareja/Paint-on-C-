namespace Paint;

public class PointBuilder : IShapeBuilder
{
    public void Draw(ShapeRequest request)
    {
        request.Image![request.Origin.X, request.Origin.Y] = request.Color;
    }
}