using System;
using System.Drawing;
using System.Windows.Forms;
using static ScreenCapturer.NativeMethods;
namespace ScreenCapturer
{
    public static class ImageHelper
    {
        /// <summary>
        /// 获屏幕截图，支持多屏
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetScreenCapture()
        {
            return GetScreenCapture(Screen.FromPoint(Cursor.Position));
        }

        /// <summary>
        /// 获屏幕截图，支持多屏
        /// </summary>
        /// <param name="screen">多屏下的指定屏幕对象</param>
        /// <returns></returns>
        public static Bitmap GetScreenCapture(Screen screen)
        {
            Rectangle rect = new Rectangle(screen.Bounds.Location.X, screen.Bounds.Location.Y, screen.Bounds.Width, screen.Bounds.Height);
            using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    IntPtr gHdc = g.GetHdc();
                    IntPtr deskHandle = GetDesktopWindow();
                    IntPtr dHdc = GetDC(deskHandle);
                    BitBlt(gHdc, 0, 0, rect.Width, rect.Height, dHdc, rect.X, rect.Y, TernaryRasterOperations.SRCCOPY);
                    ReleaseDC(deskHandle, dHdc);
                    g.ReleaseHdc(gHdc);
                    return bmp.Clone() as Bitmap;
                }
            }
        }

        /// <summary>
        /// 获取给定图像的给定范围图像
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="rectangle"></param>
        /// <returns></returns>
        public static Bitmap GetRectBitmap(this Bitmap bitmap, Rectangle rectangle)
        {
            try
            {
                if (bitmap == null) return null;
                if (rectangle.Width == 0 || rectangle.Height == 0) return null;
                Bitmap resultbitmap = new Bitmap(rectangle.Width, rectangle.Height);
                using (Graphics graphics = Graphics.FromImage(resultbitmap))
                {
                    Rectangle rect1 = new System.Drawing.Rectangle(0, 0, rectangle.Width, rectangle.Height);
                    graphics.DrawImage(bitmap, rect1, rectangle, GraphicsUnit.Pixel);
                    return resultbitmap;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
