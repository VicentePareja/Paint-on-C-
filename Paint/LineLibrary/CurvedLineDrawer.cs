using System.Drawing;

namespace LineLibrary;

public class CurvedLineDrawer : ILineDrawer
{
    private Point _center;
    private int _radius;
    private int[,] _matrix = null!;
    private double _startAngle;
    private double _endAngle;
    
    public void Draw(LineRequest lineRequest)
    {
        SetAttributes(lineRequest);
        for (double theta = _startAngle; theta <= _endAngle; theta += 0.1)
        {
            int x = (int)Math.Round(_center.X + _radius * Math.Cos(theta * Math.PI / 180));
            int y = (int)Math.Round(_center.Y + _radius * Math.Sin(theta * Math.PI / 180));
            _matrix[x, y] = 1;
        }
    }

    private void SetAttributes(LineRequest lineRequest)
    {
        Point origin = (Point)lineRequest.Origin!;
        Point destiny = (Point)lineRequest.Destiny!;
        _radius = (int) Math.Sqrt(Math.Pow(destiny.X - origin.X, 2) + Math.Pow(destiny.Y - origin.Y, 2)) / 2;
        int centerX = (origin.X + destiny.X) / 2;
        int centerY = (origin.Y + destiny.Y) / 2;
        _center = new Point(centerX, centerY);
        _matrix = lineRequest.Matrix!;
        _startAngle = Math.Atan2(origin.Y - _center.Y, origin.X - _center.X) * 180 / Math.PI;
        _endAngle = Math.Atan2(destiny.Y - _center.Y, destiny.X - _center.X) * 180 / Math.PI;
        if (!(_endAngle < _startAngle)) return;
        (_startAngle, _endAngle) = (_endAngle, _startAngle);
        _radius = -_radius;
    }
}