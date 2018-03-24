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

namespace WallpaperManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ResolutionHandler rh = new ResolutionHandler();
            rh.OrientationChanged += OrientationHandler;
        }

        private void OrientationHandler(object sender, ResolutionHandler.Orientation orientation)
        {
            MessageBox.Show("Changed orientation to " + orientation.ToString());
        }
    }
}
