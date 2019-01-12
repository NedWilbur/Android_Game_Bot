using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidGameBotLibrary
{
    class ImageReader2
    {
        public void readImage(double matchPercent = 0.98)
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(filepathB); // Image B
            Image<Bgr, byte> template = new Image<Bgr, byte>(filepathA); // Image A
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > matchPercent)
                {
                    // This is a match. Do something with it, for example draw a rectangle around it.
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);
                }
            }

            // Show imageToShow in an ImageBox (here assumed to be called imageBox1)
            imageBox1.Image = imageToShow;
        }
    }
}
