using System.Drawing;
using LineLibrary;

namespace Paint;

public class CircleBuilder : IShapeBuilder
{
    private readonly ILineDrawer _lineDrawer;

    public CircleBuilder(ILineDrawer lineDrawer)
    {
        _lineDrawer = lineDrawer;
    }

    public void Draw(ShapeRequest request)
    {
        int[,] matrix = new int[request.Image!.Width,request.Image.Height];
        LineRequest lineRequest = new LineRequest
        {
            Origin = new Point(request.Center.X + request.Radius, request.Center.Y + request.Radius),
            Destiny = new Point(request.Center.X - request.Radius, request.Center.Y - request.Radius),
            Matrix = matrix
        };
        _lineDrawer.Draw(lineRequest);
        (lineRequest.Origin, lineRequest.Destiny) = (lineRequest.Destiny, lineRequest.Origin);
        _lineDrawer.Draw(lineRequest);
        for (int i = 0; i < request.Image.Width; i++)
        {
            for (int j = 0; j < request.Image.Height; j++)
            {
                if (matrix[i, j] == 1)
                    request.Image[i, j] = request.Color;
            }   
        }
    }
}