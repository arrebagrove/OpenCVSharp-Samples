﻿using OpenCvSharp;

namespace OpenCVSharpSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            readImage1();
            readImage2();
        }

        private static void readImage1()
        {
            var img = Cv.LoadImage(@"..\..\images\ocv02.jpg", LoadMode.GrayScale);

            Cv.NamedWindow("window");
            Cv.ShowImage("window", img);

            Cv.WaitKey();

            Cv.DestroyWindow("window");

            Cv.ReleaseImage(img);
        }

        private static void readImage2()
        {
            using (var img = new IplImage(@"..\..\images\ocv02.jpg", LoadMode.Unchanged))
            {
                using (var window = new CvWindow("window"))
                {
                    window.Image = img;
                    Cv.WaitKey();
                }
            }
        }
    }
}