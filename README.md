# SharpPaint

SharpPaint is a simplified clone of the popular Paint program. It currently supports drawing basic shapes like points and circles, with plans to extend functionality to include lines and rectangles. The project demonstrates the use of design patterns, specifically the Adapter pattern, to integrate different drawing functionalities.

## Project Structure

- **Paint Namespace**: Contains the main classes for drawing shapes.
- **LineLibrary Namespace**: Contains classes for drawing lines (both straight and curved) and related interfaces.

## Classes and Interfaces

### Paint Namespace

- **Controller**: Manages the different shape builders and handles drawing requests.
  - `Controller(IEnumerable<Shape> shapes)`: Constructor to initialize the shape builders.
  - `void Handle(ShapeRequest request, int index)`: Handles drawing requests.

- **IShapeBuilder**: Interface for shape builders.
  - `void Draw(ShapeRequest request)`: Method to draw the shape.

- **PointBuilder**: Implements `IShapeBuilder` to draw points.
  - `void Draw(ShapeRequest request)`: Draws a point on the image.

- **CircleBuilder**: Implements `IShapeBuilder` to draw circles.
  - `void Draw(ShapeRequest request)`: Draws a circle on the image.

- **LineBuilder**: Implements `IShapeBuilder` to draw lines.
  - `void Draw(ShapeRequest request)`: Draws a line on the image.

- **RectangleBuilder**: Implements `IShapeBuilder` to draw rectangles.
  - `void Draw(ShapeRequest request)`: Draws a rectangle on the image.

### LineLibrary Namespace

- **ILineDrawer**: Interface for line drawers.
  - `void Draw(LineRequest lineRequest)`: Method to draw a line.

- **StraightLineDrawer**: Implements `ILineDrawer` to draw straight lines.
  - `void Draw(LineRequest lineRequest)`: Draws a straight line.

- **CurvedLineDrawer**: Implements `ILineDrawer` to draw curved lines.
  - `void Draw(LineRequest lineRequest)`: Draws a curved line.

## Usage

1. **Initialize Controller**: Create an instance of `Controller` with the required shapes.
   ```csharp
   var shapes = new List<Shape> { Shape.Point, Shape.Circle, Shape.Line, Shape.Rectangle };
   var controller = new Controller(shapes);
   ```
2. Handle Drawing Requests: Use the Handle method to draw shapes.
```
   var request = new ShapeRequest
{
    Image = new int[width, height],
    Origin = new Point(x1, y1),
    Destiny = new Point(x2, y2),
    Center = new Point(cx, cy),
    Radius = radius,
    Color = color
};
controller.Handle(request, shapeIndex);
```

Extending Functionality
To add new shapes, create a new class implementing IShapeBuilder and integrate it into the Controller class.

