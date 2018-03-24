using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WallpaperManager.Handlers;
using WallpaperManager.Transformations;

namespace WallpaperManager
{
    public partial class Form1 : Form
    {
        SystemEventHandler mResHandler;
        ImageCropper mImageCrop;

        public Form1()
        {
            InitializeComponent();

            mResHandler = new SystemEventHandler();
            mResHandler.OrientationChanged += OrientationHandler;
        }

        private void OrientationHandler(object sender, SystemEventHandler.Orientation orientation)
        {
            if (orientation == SystemEventHandler.Orientation.Landscape)
                pictureBox1.Image = mImageCrop.crop(2000, 1000, 400, 200);
            else
                pictureBox1.Image = mImageCrop.crop(2000, 1000, 200, 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = WallpaperManager.Properties.Resources.battle_board_game_chess_42070;
            mImageCrop = new ImageCropper(new Bitmap(this.pictureBox1.Image));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (mImageCrop != null)
                mImageCrop = null;

            mImageCrop = new ImageCropper(new Bitmap(this.pictureBox1.Image));
        }
    }
}
