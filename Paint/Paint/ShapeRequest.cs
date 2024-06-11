using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Point = System.Drawing.Point;

namespace Paint;

public class ShapeRequest
{
    public Image<Rgb24>? Image;
    public Rgb24 Color;
    public Point Center;
    public int Radius;
    public Point Origin;
    public Point Destiny;
}