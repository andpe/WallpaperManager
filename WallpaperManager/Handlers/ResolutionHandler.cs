using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperManager.Handlers
{
    public class ResolutionHandler
    {
        public enum Orientation
        {
            Landscape,
            Portrait
        };

        protected Orientation mOrientation;

        public event OrientationChangedHandler OrientationChanged;

        public delegate void OrientationChangedHandler(object sender, Orientation newOrientation);

        public ResolutionHandler()
        {
            SystemEvents.DisplaySettingsChanged += DisplaySettingsChanged_Handler;
        }

        ~ResolutionHandler()
        {
            // Don't leak handlers, since this is a static handler we have to do this...
            SystemEvents.DisplaySettingsChanged -= DisplaySettingsChanged_Handler;
        }

        public void DisplaySettingsChanged_Handler(object sender, EventArgs e)
        {
            // Grab the rect from the primary screen for now.
            Rectangle screenRect = Screen.PrimaryScreen.Bounds;

            // Figure out what our orientation is and trigger orientation changed if we have changed orientation
            // since last time we checked the bounds.
            Orientation newOrientation = screenRect.Width > screenRect.Height ? Orientation.Landscape : Orientation.Portrait;
            if (mOrientation != newOrientation && this.OrientationChanged != null)
            {
                mOrientation = newOrientation;
                this.OrientationChanged(this, newOrientation);
            }
        }
    }
}
