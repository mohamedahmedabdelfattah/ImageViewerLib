using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using openCV;
using System.Drawing;

namespace ImageViewerLib
{
    public class Image
    {

        public IplImage ResizeImage(Image originalImage, Int32 newWidth, Int32 newHeight)
        {
            IplImage img, resizedimage;

            //cvlib.CvCreateImage();

            Int32 width = newWidth, height = newHeight;

            CvSize size = new CvSize(width, height);

            resizedimage = cvlib.CvCreateImage(size, img.depth, img.nChannels);

            cvlib.CvResize(ref originalImage, ref resizedimage, cvlib.CV_INTER_LINEAR);

            return resizedimage;
        }

    }
}