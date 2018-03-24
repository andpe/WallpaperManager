using Microsoft.VisualStudio.TestTools.UnitTesting;
using WallpaperManager.Transformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WallpaperManager.Transformations.Tests
{
    [TestClass()]
    public class ImageCropperTests
    {
        [TestMethod()]
        public void cropTest()
        {
            ImageCropper ic = new ImageCropper(Image.FromFile("testResources/test.png"));

            Image im = ic.crop(20, 20, 10, 10);

            Assert.AreEqual(10, im.Width);
            Assert.AreEqual(10, im.Height);
        }
    }
}