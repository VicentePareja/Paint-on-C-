using System.Drawing;

namespace LineLibrary;

public class StraightLineDrawer : ILineDrawer
{
    private Point _origin;
    private Point _destiny;
    private int[,] _matrix = null!;

    public void Draw(LineRequest lineRequest)
    {
        SetAttributes(lineRequest);
        int deltaX = _destiny.X - _origin.X;
        int deltaY = _destiny.Y - _origin.Y;

        if (Math.Abs(deltaX) >= Math.Abs(deltaY))
            DrawFromXCoordinate(deltaX, deltaY);
        else
            DrawFromYCoordinate(deltaX, deltaY);            
    }

    private void SetAttributes(LineRequest lineRequest)
    {
        _origin = (Point)lineRequest.Origin!;
        _destiny = (Point)lineRequest.Destiny!;
        _matrix = lineRequest.Matrix!;
    }

    private void DrawFromXCoordinate(int deltaX, int deltaY)
    {
        int step = Math.Sign(deltaX);
        double slope = (double)deltaY / deltaX;

        for (int x = _origin.X; x != _destiny.X + step; x += step)
        {
            int y = (int)Math.Round(_origin.Y + slope * (x - _origin.X));
            _matrix[x, y] = 1;
        }
    }
    
    private void DrawFromYCoordinate(int deltaX, int deltaY)
    {
        int step = Math.Sign(deltaY);
        double slope = (double)deltaX / deltaY;

        for (int y = _origin.Y; y != _destiny.Y + step; y += step)
        {
            int x = (int)Math.Round(_origin.X + slope * (y - _origin.Y));
            _matrix[x, y] = 1;
        }
    }
}