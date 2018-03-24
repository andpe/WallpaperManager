using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WallpaperManager.Transformations
{
    public class ImageCropper
    {
        #region Members
        protected Image mImage;
        #endregion

        public ImageCropper(Image image)
        {
            mImage = image;
        }

        ~ImageCropper()
        {
            mImage.Dispose();
        }

        /// <summary>
        /// Crop the image assigned to this instance.
        /// </summary>
        /// <param name="startx">Starting coord for X</param>
        /// <param name="starty">Starting coord for Y</param>
        /// <param name="width">End coord for X</param>
        /// <param name="height">End coord for Y</param>
        public Image crop(int startx, int starty, int width, int height)
        {
            Rectangle sourceRectangle = new Rectangle(startx, starty, width, height);
            Bitmap srcBitmap = mImage as Bitmap;
            Bitmap dstBitmap = new Bitmap(sourceRectangle.Width, sourceRectangle.Height);

            // Make sure the dst bitmap has the same resolution as the source one.
            dstBitmap.SetResolution(srcBitmap.VerticalResolution, srcBitmap.HorizontalResolution);

            using (Graphics g = Graphics.FromImage(dstBitmap))
            {
                g.DrawImage(srcBitmap, new Rectangle(0, 0, width, height), sourceRectangle, GraphicsUnit.Pixel);
            }

            return dstBitmap;
        }
    }
}
