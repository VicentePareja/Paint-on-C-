using System.Drawing;
using LineLibrary;

namespace Paint
{
    public class LineBuilder : IShapeBuilder
    {
        private readonly ILineDrawer _lineDrawer;

        public LineBuilder(ILineDrawer lineDrawer)
        {
            _lineDrawer = lineDrawer;
        }

        public void Draw(ShapeRequest request)
        {
            int[,] matrix = new int[request.Image!.Width, request.Image.Height];
            LineRequest lineRequest = new LineRequest
            {
                Origin = request.Origin,
                Destiny = request.Destiny,
                Matrix = matrix
            };
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
}