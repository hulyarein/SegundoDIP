using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoDIP
{
    static class DIPHelper
    {
        private static void ResizeBitmap(ref Bitmap original, ref Bitmap resized, int newWidth, int newHeight)
        {
            resized = new Bitmap(newWidth, newHeight);

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int sourceX = x * original.Width / newWidth;
                    int sourceY = y * original.Height / newHeight;
                    resized.SetPixel(x, y, original.GetPixel(sourceX, sourceY));
                }
            }
        }

        public static void RemoveGreen(ref Bitmap background, ref Bitmap foreground, ref Bitmap resultImage)
        {
            Color greenColor = Color.FromArgb(0, 255, 0);
            int greenIntensity = greenColor.G;
            int tolerance = 50;

            Bitmap scaledForeground = new Bitmap(background.Width, background.Height);

            ResizeBitmap(ref foreground, ref scaledForeground, background.Width, background.Height);

            Bitmap compositeImage = new Bitmap(scaledForeground.Width, scaledForeground.Height);

            for (int x = 0; x < scaledForeground.Width; x++)
            {
                for (int y = 0; y < scaledForeground.Height; y++)
                {
                    Color fgPixel = scaledForeground.GetPixel(x, y);
                    Color bgPixel = background.GetPixel(x, y);

                    int greenComponent = fgPixel.G;
                    int difference = Math.Abs(greenIntensity - greenComponent);

                    if (difference <= tolerance)
                    {
                        compositeImage.SetPixel(x, y, bgPixel);
                    }
                    else
                    {
                        compositeImage.SetPixel(x, y, fgPixel);
                    }
                }
            }

            resultImage = compositeImage;
        }

        public static void ApplyInversion(ref Bitmap original, ref Bitmap invertedImage)
        {
            Bitmap invertedBitmap = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    invertedBitmap.SetPixel(x, y, invertedPixel);
                }
            }

            invertedImage = invertedBitmap;
        }

        public static void ApplySepiaTone(ref Bitmap original, ref Bitmap sepiaImage)
        {
            Bitmap sepiaBitmap = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);

                    int sepiaRed = Math.Min((int)(pixel.R * .393 + pixel.G * .769 + pixel.B * .189), 255);
                    int sepiaGreen = Math.Min((int)(pixel.R * .349 + pixel.G * .686 + pixel.B * .168), 255);
                    int sepiaBlue = Math.Min((int)(pixel.R * .272 + pixel.G * .534 + pixel.B * .131), 255);

                    Color sepiaColor = Color.FromArgb(sepiaRed, sepiaGreen, sepiaBlue);
                    sepiaBitmap.SetPixel(x, y, sepiaColor);
                }
            }

            sepiaImage = sepiaBitmap;
        }

        public static void DuplicateBitmap(ref Bitmap original, ref Bitmap duplicate)
        {
            duplicate = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    duplicate.SetPixel(i, j, original.GetPixel(i, j));
                }
            }
        }

        public static void GenerateHistogram(ref Bitmap original, ref Bitmap histogramImage)
        {
            Bitmap grayscaleImage = new Bitmap(original.Width, original.Height);
            int[] histogramValues = new int[256];

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    byte grayscaleValue = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                    grayscaleImage.SetPixel(x, y, Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue));
                    histogramValues[grayscaleValue]++;
                }
            }

            histogramImage = new Bitmap(256, 400);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histogramValues[x] / 10, histogramImage.Height - 1); y++)
                {
                    histogramImage.SetPixel(x, histogramImage.Height - 1 - y, Color.Black);
                }
            }
        }

        public static void ConvertToGrayscale(ref Bitmap original, ref Bitmap grayscaleImage)
        {
            grayscaleImage = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    byte grayscaleValue = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                    grayscaleImage.SetPixel(x, y, Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue));
                }
            }
        }
    }
}
