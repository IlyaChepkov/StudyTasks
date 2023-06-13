using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IlyaCode
{
    internal class Imager
    {
        public static void Do()
        {
            Console.WriteLine("Введите имя файла");
            string input = Console.ReadLine();
            Bitmap image = Bitmap.FromFile(input) as Bitmap;
            BlackWhite(image);
            image.Save(input + "BlackWhite.bmp");
            image = Bitmap.FromFile(input) as Bitmap;
            TwoColor(image);
            image.Save(input + "TwoColor.bmp");
            image = Bitmap.FromFile(input) as Bitmap;
            Negative(image);
            image.Save(input + "Negative.bmp");
        }

        public static void BlackWhite(Bitmap image)
        {
            for(int i = 0; i < image.Height; i++)
            {
                for(int j = 0; j < image.Width; j++)
                {
                    Color input = image.GetPixel(j, i);
                    int avg = (input.R + input.G + input.B) / 3;
                    image.SetPixel(j, i, Color.FromArgb(avg, avg, avg));
                }
            }
        }

        public static void TwoColor(Bitmap image)
        
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color input = image.GetPixel(j, i);
                    int avg = (input.R + input.G + input.B) / 3;
                    if (avg > 128)
                    {
                        image.SetPixel(j, i, Color.White);
                    }
                    else
                    {
                        image.SetPixel(j, i, Color.Black);
                    }
                    
                }
            }
        }

        public static void Negative(Bitmap image)
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color input = image.GetPixel(j, i);
                    image.SetPixel(j, i, Color.FromArgb(255 - input.R, 255 - input.G, 255 - input.B));
                }
            }
        }
    }
}
