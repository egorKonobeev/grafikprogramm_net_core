using ImageTools;
using SkiaSharp;

namespace Grafikprogramm
{
  class Rectangle : IImage
    {

        private readonly SKColor ForegroundColor = SKColors.Red;

        private readonly SKColor BackgroundColor = SKColors.LightGreen;

        private Point TopLeft;
    
        private Point BottomRight;

        public Rectangle(SKColor foregroundColor, SKColor backgroundColor, 
            int topLeftX, int topLeftY,int width, int height)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            TopLeft = new Point(topLeftX, topLeftY);
            BottomRight = new Point(topLeftX + width, topLeftY + height);           
        }

        public SKColor GetPixelColor(int x, int y)
        {
            if (x >= TopLeft.X && y >= TopLeft.Y &&
                x <= BottomRight.X && y <= BottomRight.Y)

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
