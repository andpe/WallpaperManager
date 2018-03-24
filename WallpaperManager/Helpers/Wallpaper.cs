using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.Win32;

namespace WallpaperManager.Helpers
{
    /// <summary>
    /// Helper class for setting wallpapers in Windows.
    /// </summary>
    public class Wallpaper
    {
        public const int SPI_SETDESKWALLPAPER = 0x14;
        public const int SPIF_UPDATEINIFILE = 0x01;
        public const int SPIF_SPIF_SENDWININICHANGE = 0x02;

        // Import the call we need for setting system parameters.
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        /// <summary>
        /// Set the background wallpaper for the current system.
        /// </summary>
        /// <param name="img">Image object to save and use as a background image.</param>
        /// <param name="style">The style this wallpaper should be saved with.</param>
        public static void setBackground(Image img, WallpaperStyle style)
        {
            // Save the image to a temporary bmp file.
            String tmp = Path.GetTempPath();
            img.Save(Path.Combine(tmp, "bg.bmp"), ImageFormat.Bmp);

            // Update registry values.
            setRegistryValues(style);

            // Tell the system we have a new background.
            SystemParametersInfo(
                SPI_SETDESKWALLPAPER,
                0,
                Path.Combine(tmp, "bg.bmp"),
                SPIF_UPDATEINIFILE | SPIF_SPIF_SENDWININICHANGE
            );
        } 

        private static void setRegistryValues(WallpaperStyle style)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            switch(style)
            {
                case WallpaperStyle.Centered:
                    key.SetValue("WallpaperStyle", 1);
                    key.SetValue("TileWallpaper", 0);
                    break;
                case WallpaperStyle.Stretched:
                    key.SetValue("WallpaperStyle", 2);
                    key.SetValue("TileWallpaper", 0);
                    break;
                case WallpaperStyle.Tiled:
                    key.SetValue("WallpaperStyle", 1);
                    key.SetValue("TileWallpaper", 1);
                    break;
            }
        }
    }

    public enum WallpaperStyle
    {
        Centered,
        Stretched,
        Tiled
    }
}
