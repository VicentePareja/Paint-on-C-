namespace Paint;

using LineLibrary;

public class Controller
{
    private readonly List<IShapeBuilder> _shapeBuilders = new();

    public Controller(IEnumerable<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            IShapeBuilder builder = shape switch
            {
                Shape.Point => new PointBuilder(),
                Shape.Circle => new CircleBuilder(new CurvedLineDrawer()),
                Shape.Line => new LineBuilder(new StraightLineDrawer()),
                Shape.Rectangle => new RectangleBuilder(new StraightLineDrawer()),
                _ => throw new ArgumentException("Unknown shape type", nameof(shape))
            };
            _shapeBuilders.Add(builder);
        }
    }

    public void Handle(ShapeRequest request, int index)
        => _shapeBuilders[index].Draw(request);
}