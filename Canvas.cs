using ImageTools;
using SkiaSharp;
using System.Collections.Generic;

namespace Grafikprogramm
{
  public class Canvas : IImage
    {

        private readonly List<IImage> Shapes = new List<IImage>();

        private readonly int CanvasWidth;

        private readonly int CanvasHeight;

        public Canvas(int canvasWidth, int canvasHeight)
        {
            CanvasWidth = canvasWidth;
            CanvasHeight = canvasHeight;
        }

        public void AddShape(IImage shape)
        {
            Shapes.Add(shape);
        }

        public SKColor GetPixelColor(int x, int y)
        {

            foreach (IImage shape in Shapes)
            {
                SKColor shapeColor = shape.GetPixelColor(x, y);       
                if(shapeColor != SKColors.Transparent)
                {
                    return shapeColor;
                }

            }
            return SKColors.Transparent;

        }

        public int Height()
        {
            return CanvasHeight;
        }

        public int Width()
        {
            return CanvasWidth;
        }
    }
}
