using ImageTools;
using SkiaSharp;
using System;

namespace Grafikprogramm
{
    public class Circle : IImage
    {

        private readonly SKColor ForegroundColor = SKColors.Red;

        private readonly SKColor BackgroundColor = SKColors.LightGreen;

        private readonly int CircleCenterX = 300;

        private readonly int CircleCenterY = 50;

        private readonly int Radius = 70;

        public Circle() { }

        public Circle(SKColor foregroundColor, SKColor backgroundColor, int circleCenterX, int circleCenterY, int radius)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            CircleCenterX = circleCenterX;
            CircleCenterY = circleCenterY;
            Radius = radius;
        }

        public SKColor GetPixelColor(int x, int y)
        {
            int xDifference = x - CircleCenterX;
            int yDifference = y - CircleCenterY;
            double distance = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
            if (distance <= Radius)
            {
                return ForegroundColor;
            }
            return BackgroundColor;
        }

        public int Height()
        {
            return 300;
        }

        public int Width()
        {
            return 400;
        }
    }
}