using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Point = System.Drawing.Point;

namespace Paint.Tests;

public class ControllerTests
{
    private readonly ShapeRequest[] _circleRequests =
    [
        new ShapeRequest
        {
            Color = new Rgb24(78, 171, 26),        
            Center = new Point(181, 486),
            Radius = 7
        },
        new ShapeRequest
        {
            Color = new Rgb24(127, 46, 238),
            Center = new Point(387, 139),
            Radius = 68
        },
        new ShapeRequest
        {
            Color = new Rgb24(230, 45, 99),
            Center = new Point(25, 296),
            Radius = 18
        },
        new ShapeRequest
        {
            Color = new Rgb24(171, 132, 227),
            Center = new Point(122, 393),
            Radius = 73
        },
        new ShapeRequest
        {
            Color = new Rgb24(62, 125, 37),
            Center = new Point(203, 137),
            Radius = 90
        },
        new ShapeRequest
        {
            Color = new Rgb24(219, 171, 126),
            Center = new Point(420, 406),
            Radius = 50
        },
        new ShapeRequest
        {
            Color = new Rgb24(116, 19, 231),
            Center = new Point(434, 373),
            Radius = 40
        },
        new ShapeRequest
        {
            Color = new Rgb24(62, 255, 142),
            Center = new Point(212, 226),
            Radius = 116
        },
        new ShapeRequest
        {
            Color = new Rgb24(125, 89, 13),
            Center = new Point(217, 302),
            Radius = 14
        },
        new ShapeRequest
        {
            Color = new Rgb24(85, 82, 230),
            Center = new Point(342, 272),
            Radius = 100
        },
        new ShapeRequest
        {
            Color = new Rgb24(244, 231, 45),       
            Center = new Point(368, 452),
            Radius = 33
        },
        new ShapeRequest
        {
            Color = new Rgb24(119, 79, 78),
            Center = new Point(232, 246),
            Radius = 27
        },
        new ShapeRequest
        {
            Color = new Rgb24(13, 160, 207),
            Center = new Point(22, 372),
            Radius = 15
        },
        new ShapeRequest
        {
            Color = new Rgb24(72, 164, 247),
            Center = new Point(18, 332),
            Radius = 10
        },
        new ShapeRequest
        {
            Color = new Rgb24(206, 239, 248),
            Center = new Point(439, 52),
            Radius = 15
        },
        new ShapeRequest
        {
            Color = new Rgb24(184, 10, 39),
            Center = new Point(76, 149),
            Radius = 34
        },
        new ShapeRequest
        {
            Color = new Rgb24(202, 138, 200),
            Center = new Point(350, 409),
            Radius = 30
        },
        new ShapeRequest
        {
            Color = new Rgb24(191, 204, 192),
            Center = new Point(207, 199),
            Radius = 133
        },
        new ShapeRequest
        {
            Color = new Rgb24(12, 153, 87),
            Center = new Point(264, 225),
            Radius = 153
        },
        new ShapeRequest
        {
            Color = new Rgb24(3, 57, 101),
            Center = new Point(267, 468),
            Radius = 17
        }
    ];

    private readonly ShapeRequest[] _pointRequests =
    [
        new ShapeRequest
        {
            Color = new Rgb24(244, 201, 11),       
            Origin = new Point(192, 465),
        },
        new ShapeRequest
        {
            Color = new Rgb24(109, 224, 80),       
            Origin = new Point(788, 231),
        },
        new ShapeRequest
        {
            Color = new Rgb24(97, 251, 25),
            Origin = new Point(288, 833),
        },
        new ShapeRequest
        {
            Color = new Rgb24(249, 32, 35),
            Origin = new Point(513, 248),
        },
        new ShapeRequest
        {
            Color = new Rgb24(139, 207, 106),
            Origin = new Point(382, 41),
        },
        new ShapeRequest
        {
            Color = new Rgb24(47, 71, 238),
            Origin = new Point(821, 488),
        },
        new ShapeRequest
        {
            Color = new Rgb24(27, 165, 65),
            Origin = new Point(40, 203),
        },
        new ShapeRequest
        {
            Color = new Rgb24(131, 30, 213),
            Origin = new Point(648, 842),
        },
        new ShapeRequest
        {
            Color = new Rgb24(0, 107, 111),
            Origin = new Point(254, 644),
        },
        new ShapeRequest
        {
            Color = new Rgb24(117, 125, 122),
            Origin = new Point(336, 798),
        },
        new ShapeRequest
        {
            Color = new Rgb24(198, 70, 163),
            Origin = new Point(751, 514),
        },
        new ShapeRequest
        {
            Color = new Rgb24(92, 225, 244),
            Origin = new Point(525, 757),
        },
        new ShapeRequest
        {
            Color = new Rgb24(201, 226, 59),
            Origin = new Point(293, 600),
        },
        new ShapeRequest
        {
            Color = new Rgb24(136, 228, 77),
            Origin = new Point(901, 277),
        },
        new ShapeRequest
        {
            Color = new Rgb24(47, 112, 158),
            Origin = new Point(889, 775),
        },
        new ShapeRequest
        {
            Color = new Rgb24(248, 253, 13),
            Origin = new Point(7, 383),
        },
        new ShapeRequest
        {
            Color = new Rgb24(102, 69, 31),
            Origin = new Point(649, 192),
        },
        new ShapeRequest
        {
            Color = new Rgb24(67, 126, 193),
            Origin = new Point(569, 725),
        },
        new ShapeRequest
        {
            Color = new Rgb24(237, 197, 249),
            Origin = new Point(320, 201),
        },
        new ShapeRequest
        {
            Color = new Rgb24(182, 136, 219),
            Origin = new Point(550, 620),
        }
    ];
    
    private readonly ShapeRequest[] _lineRequests =
    [
        new ShapeRequest
        {
           Color = new Rgb24(254, 87, 53),
           Origin = new Point(231, 593),
           Destiny = new Point(930, 726),
        },
        new ShapeRequest
            {
           Color = new Rgb24(239, 89, 124),
           Origin = new Point(797, 692),
           Destiny = new Point(863, 243),
        },
        new ShapeRequest
        {
           Color = new Rgb24(7, 119, 86),
           Origin = new Point(175, 334),
           Destiny = new Point(612, 728),
        },
        new ShapeRequest
        {
           Color = new Rgb24(226, 228, 88),
           Origin = new Point(96, 205),
           Destiny = new Point(543, 58),
        },
        new ShapeRequest
        {
           Color = new Rgb24(98, 151, 142),
           Origin = new Point(715, 758),
           Destiny = new Point(670, 92),
        },
        new ShapeRequest
        {
           Color = new Rgb24(7, 23, 60),
           Origin = new Point(298, 921),
           Destiny = new Point(789, 237),
        },
        new ShapeRequest
        {
           Color = new Rgb24(162, 241, 40),
           Origin = new Point(289, 173),
           Destiny = new Point(210, 808),
        },
        new ShapeRequest
        {
           Color = new Rgb24(188, 235, 200),
           Origin = new Point(933, 897),
           Destiny = new Point(91, 895),
        },
        new ShapeRequest
        {
           Color = new Rgb24(137, 186, 133),
           Origin = new Point(987, 595),
           Destiny = new Point(200, 443),
        },
        new ShapeRequest
        {
           Color = new Rgb24(64, 21, 49),
           Origin = new Point(504, 316),
           Destiny = new Point(365, 242),
        },
        new ShapeRequest
        {
           Color = new Rgb24(82, 141, 92),
           Origin = new Point(820, 929),
           Destiny = new Point(819, 272),
        },
        new ShapeRequest
        {
           Color = new Rgb24(194, 28, 246),
           Origin = new Point(573, 853),
           Destiny = new Point(743, 910),
        },
        new ShapeRequest
        {
           Color = new Rgb24(38, 156, 101),
           Origin = new Point(844, 666),
           Destiny = new Point(534, 417),
        },
        new ShapeRequest
        {
           Color = new Rgb24(238, 20, 215),
           Origin = new Point(636, 46),
           Destiny = new Point(430, 940),
        },
        new ShapeRequest
        {
           Color = new Rgb24(81, 149, 24),
           Origin = new Point(951, 825),
           Destiny = new Point(394, 737),
        },
        new ShapeRequest
        {
           Color = new Rgb24(73, 71, 81),
           Origin = new Point(111, 919),
           Destiny = new Point(976, 748),
        },
        new ShapeRequest
        {
           Color = new Rgb24(46, 22, 63),
           Origin = new Point(289, 955),
           Destiny = new Point(834, 291),
        },
        new ShapeRequest
        {
           Color = new Rgb24(85, 64, 112),
           Origin = new Point(629, 230),
           Destiny = new Point(826, 575),
        },
        new ShapeRequest
        {
           Color = new Rgb24(122, 75, 46),
           Origin = new Point(666, 484),
           Destiny = new Point(122, 430),
        },
        new ShapeRequest
        {
           Color = new Rgb24(192, 159, 250),
           Origin = new Point(647, 203),
           Destiny = new Point(394, 299),
        }
    ];

    private readonly ShapeRequest[] _rectangleRequests =
    [
        new ShapeRequest
        {
           Color = new Rgb24(3, 123, 213),
           Origin = new Point(125, 739),
           Destiny = new Point(73, 168),
        },
        new ShapeRequest
        {
           Color = new Rgb24(160, 211, 96),
           Origin = new Point(11, 992),
           Destiny = new Point(793, 70),
        },
        new ShapeRequest
        {
           Color = new Rgb24(133, 87, 12),
           Origin = new Point(154, 901),
           Destiny = new Point(177, 945),
        },
        new ShapeRequest
        {
           Color = new Rgb24(220, 222, 231),
           Origin = new Point(554, 42),
           Destiny = new Point(553, 913),
        },
        new ShapeRequest
        {
           Color = new Rgb24(27, 192, 80),
           Origin = new Point(471, 510),
           Destiny = new Point(27, 40),
        },
        new ShapeRequest
        {
           Color = new Rgb24(4, 45, 95),
           Origin = new Point(315, 936),
           Destiny = new Point(88, 236),
        },
        new ShapeRequest
        {
           Color = new Rgb24(51, 74, 18),
           Origin = new Point(58, 404),
           Destiny = new Point(253, 59),
        },
        new ShapeRequest
        {
           Color = new Rgb24(236, 187, 78),
           Origin = new Point(885, 922),
           Destiny = new Point(477, 46),
        },
        new ShapeRequest
        {
           Color = new Rgb24(193, 78, 247),
           Origin = new Point(186, 507),
           Destiny = new Point(54, 474),
        },
        new ShapeRequest
        {
           Color = new Rgb24(128, 21, 197),
           Origin = new Point(836, 933),
           Destiny = new Point(507, 411),
        },
        new ShapeRequest
        {
           Color = new Rgb24(52, 164, 27),
           Origin = new Point(149, 950),
           Destiny = new Point(749, 289),
        },
        new ShapeRequest
        {
           Color = new Rgb24(54, 204, 251),
           Origin = new Point(873, 648),
           Destiny = new Point(713, 464),
        },
        new ShapeRequest
        {
           Color = new Rgb24(35, 246, 41),
           Origin = new Point(459, 893),
           Destiny = new Point(991, 563),
        },
        new ShapeRequest
        {
           Color = new Rgb24(85, 251, 159),
           Origin = new Point(550, 802),
           Destiny = new Point(214, 345),
        },
        new ShapeRequest
        {
           Color = new Rgb24(159, 204, 28),
           Origin = new Point(318, 999),
           Destiny = new Point(617, 266),
        },
        new ShapeRequest
        {
           Color = new Rgb24(4, 57, 181),
           Origin = new Point(327, 686),
           Destiny = new Point(416, 14),
        },
        new ShapeRequest
        {
           Color = new Rgb24(78, 119, 231),
           Origin = new Point(811, 979),
           Destiny = new Point(231, 7),
        },
        new ShapeRequest
        {
           Color = new Rgb24(76, 191, 105),
           Origin = new Point(302, 473),
           Destiny = new Point(495, 237),
        },
        new ShapeRequest
        {
           Color = new Rgb24(208, 250, 192),
           Origin = new Point(445, 173),
           Destiny = new Point(61, 127),
        },
        new ShapeRequest
        {
           Color = new Rgb24(98, 47, 102),
           Origin = new Point(952, 586),
           Destiny = new Point(620, 471),
        }
    ];
    
    [Theory]
    [InlineData("image_0.png", new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [InlineData("image_1.png", new [] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
    [InlineData("image_2.png", new [] { 14, 1, 2, 13, 7, 12, 3, 19, 9, 16, 4, 15, 6, 5 })]
    [InlineData("image_3.png", new [] { 14, 13, 10, 11, 5, 6, 9, 15, 8 })]
    [InlineData("image_4.png", new [] { 12, 0, 14, 5, 15, 8, 19, 18, 1, 16, 4, 3, 9, 13 })]
    public void PartA_Circle(string expectedImagePath, int[] indexs)
    {
        Image<Rgb24> expectedImage = Image.Load<Rgb24>(expectedImagePath);
        Image<Rgb24> image = new Image<Rgb24>(expectedImage.Width, expectedImage.Height);
        IEnumerable<Shape> shapes = new[] { Shape.Circle };
        Controller controller = new Controller(shapes);
        foreach (var index in indexs)
        {
            ShapeRequest request = _circleRequests[index];
            request.Image = image;
            controller.Handle(request, 0);
        }

        AssertImage(expectedImage, image);
    }

    [Theory]
    [InlineData("image_5.png", new [] { 18, 15, 8, 7, 13, 3, 4 })]
    [InlineData("image_6.png", new [] { 4, 18, 12, 6, 13, 8, 19, 5, 7, 11, 3, 16, 2, 15, 9, 10, 0, 17, 1 })]
    [InlineData("image_7.png", new [] { 2, 0, 4 })]
    [InlineData("image_8.png", new [] { 11, 8, 19, 16 })]
    [InlineData("image_9.png", new [] { 4, 17, 19, 13, 16, 18, 3, 9, 5, 11, 10, 8, 15, 14, 1, 6, 2 })]
    public void PartA_Point(string expectedImagePath, int[] indexs)
    {
        Image<Rgb24> expectedImage = Image.Load<Rgb24>(expectedImagePath);
        Image<Rgb24> image = new Image<Rgb24>(expectedImage.Width, expectedImage.Height);
        IEnumerable<Shape> shapes = new[] { Shape.Point };
        Controller controller = new Controller(shapes);
        foreach (var index in indexs)
        {
            ShapeRequest request = _pointRequests[index];
            request.Image = image;
            controller.Handle(request, 0);
        }

        AssertImage(expectedImage, image);
    }
    
    [Theory]
    [InlineData("image_10.png", new [] { 8, 10, 14, 1, 4, 13, 9, 3, 0 }, new [] { 5, 2, 6, 17, 12, 3, 7, 1, 11, 4, 15, 19, 14 })]
    [InlineData("image_11.png", new [] { 8, 4, 18, 9, 14, 10, 17, 0, 2, 3, 12, 1, 19, 16, 13 }, new [] { 16, 18, 2, 7, 8, 4, 10, 11, 13, 15 })]
    [InlineData("image_12.png", new [] { 14, 13, 2, 15, 3, 0, 19, 11, 5, 9, 16, 12 }, new [] { 3, 9, 15, 13, 17, 8, 18, 4, 12, 2, 16, 10 })]
    [InlineData("image_13.png", new [] { 4, 12, 18, 10, 7, 9, 0, 2, 5, 15, 13, 16, 11, 19, 14, 8, 1 }, new [] { 1, 10, 2, 3, 9, 11, 5, 17, 4, 14 })]
    [InlineData("image_14.png", new [] { 17 }, new [] { 11, 12, 8, 16, 13, 7, 9, 1, 2, 0, 3, 15, 18 })]
    public void PartA_Multiple(string expectedImagePath, int[] pointIndexs, int[] circleIndexs)
    {
        Image<Rgb24> expectedImage = Image.Load<Rgb24>(expectedImagePath);
        Image<Rgb24> image = new Image<Rgb24>(expectedImage.Width, expectedImage.Height);
        IEnumerable<Shape> shapes = new[] { Shape.Point, Shape.Circle };
        Controller controller = new Controller(shapes);
        foreach (var index in pointIndexs)
        {
            ShapeRequest request = _pointRequests[index];
            request.Image = image;
            controller.Handle(request, 0);
        }
        
        foreach (var index in circleIndexs)
        {
            ShapeRequest request = _circleRequests[index];
            request.Image = image;
            controller.Handle(request, 1);
        }

        AssertImage(expectedImage, image);
    }
    
    [Theory]
    [InlineData("image_15.png", new [] { 12 }, new [] { 17, 14, 7, 5 },
        new[] {10, 3, 6, 7, 13, 0, 2, 18, 12, 14}, new[] {12, 8, 5, 19})]
    [InlineData("image_16.png", new [] { 7, 0, 4, 5, 15, 19, 17, 6, 8, 16, 2, 9, 1, 13 }, new [] { 16, 18, 9, 14, 12, 5, 19, 6, 13, 10, 2, 1, 11, 7 },
        new[] {19, 13, 8, 18, 1, 16, 14, 12, 0, 4, 6, 11, 7, 3, 2, 17, 15, 5, 10}, new[] {8, 6, 5, 3, 13, 15, 14, 0, 7, 12, 10, 18, 16})]
    [InlineData("image_17.png", new [] { 3, 12, 7, 15, 5, 16, 10, 11, 0, 17, 18, 19, 1, 14, 9, 8 }, new [] { 7, 3, 13, 14, 5, 19, 6, 12, 2, 16, 17, 1, 8, 15 },
        new[] {9, 17, 11, 1, 12, 8, 13, 16, 19, 10, 3, 18, 5, 2, 14}, new[] {8, 19, 2})]
    [InlineData("image_18.png", new [] { 13, 11, 18, 16, 3, 8, 1, 17, 0, 7, 9 }, new [] { 0, 7, 3, 12, 10, 5, 16, 8, 15, 18, 19 },
        new[] {9, 18, 1, 4, 3, 13}, new[] {14, 6, 17, 8, 11})]
    [InlineData("image_19.png", new [] { 9, 11, 13, 6, 18, 19, 14, 15, 0, 10, 5, 8, 12, 16, 7, 3, 1 }, new [] { 14, 10, 11, 0, 16, 13, 12, 5, 18, 2, 6, 3, 7, 1, 15, 9, 4, 8, 17 },
        new[] {5, 15, 18, 10, 3, 0, 1}, new[] {2, 3, 5, 4})]
    public void PartB(string expectedImagePath, int[] pointIndexs, int[] circleIndexs, int[] lineIndexs, int[] rectangleIndexs)
    {
        Image<Rgb24> expectedImage = Image.Load<Rgb24>(expectedImagePath);
        Image<Rgb24> image = new Image<Rgb24>(expectedImage.Width, expectedImage.Height);
        IEnumerable<Shape> shapes = new[] { Shape.Point, Shape.Circle, Shape.Line, Shape.Rectangle };
        Controller controller = new Controller(shapes);
        foreach (var index in pointIndexs)
        {
            ShapeRequest request = _pointRequests[index];
            request.Image = image;
            controller.Handle(request, 0);
        }
        
        foreach (var index in circleIndexs)
        {
            ShapeRequest request = _circleRequests[index];
            request.Image = image;
            controller.Handle(request, 1);
        }
        
        foreach (var index in lineIndexs)
        {
            ShapeRequest request = _lineRequests[index];
            request.Image = image;
            controller.Handle(request, 2);
        }
        
        foreach (var index in rectangleIndexs)
        {
            ShapeRequest request = _rectangleRequests[index];
            request.Image = image;
            controller.Handle(request, 3);
        }

        AssertImage(expectedImage, image);
    }
    
    private static void AssertImage(Image<Rgb24> expectedImage, Image<Rgb24> image)
    {
        for (int i = 0; i < expectedImage.Width; i++)
        {
            for (int j = 0; j < expectedImage.Height; j++)
            {
                Assert.Equal(expectedImage[i, j], image[i, j]);
            }
        }
    }
}