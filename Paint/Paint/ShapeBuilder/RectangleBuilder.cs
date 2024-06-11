using System.Drawing;
using LineLibrary;

namespace Paint
{
    public class RectangleBuilder : IShapeBuilder
    {
        private readonly ILineDrawer _lineDrawer;

        public RectangleBuilder(ILineDrawer lineDrawer)
        {
            _lineDrawer = lineDrawer;
        }

        public void Draw(ShapeRequest request)
        {
            int[,] matrix = new int[request.Image!.Width, request.Image.Height];
            
            Point topLeft = request.Origin;
            Point topRight = new Point(request.Destiny.X, request.Origin.Y);
            Point bottomLeft = new Point(request.Origin.X, request.Destiny.Y);
            Point bottomRight = request.Destiny;
            
            DrawLine(matrix, topLeft, topRight);
            DrawLine(matrix, topRight, bottomRight);
            DrawLine(matrix, bottomRight, bottomLeft);
            DrawLine(matrix, bottomLeft, topLeft);

            for (int i = 0; i < request.Image.Width; i++)
            {
                for (int j = 0; j < request.Image.Height; j++)
                {
                    if (matrix[i, j] == 1)
                        request.Image[i, j] = request.Color;
                }   
            }
        }

        private void DrawLine(int[,] matrix, Point origin, Point destiny)
        {
            LineRequest lineRequest = new LineRequest
            {
                Origin = origin,
                Destiny = destiny,
                Matrix = matrix
            };
            _lineDrawer.Draw(lineRequest);
        }
    }
}