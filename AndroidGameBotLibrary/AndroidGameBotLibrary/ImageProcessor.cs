using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidGameBotLibrary
{
    public static class ImageProcessor
    {
        /// <summary>
        /// Resizes, rotates (if needed), and converts image to BMP
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="rotate"></param>
        public static void DowngradeImage(string imageFile, string outputFile, bool rotate)
        {
            // Read from file
            using (MagickImage image = new MagickImage(imageFile))
            {
                MagickGeometry size = new MagickGeometry(400, 225); //25% original file size
                size.IgnoreAspectRatio = true;
                image.Resize(size);
                if (rotate) image.Rotate(90);
                image.Format = MagickFormat.Bmp;

                //Save Image
                image.Write(outputFile);
            }
        }
    }
}
