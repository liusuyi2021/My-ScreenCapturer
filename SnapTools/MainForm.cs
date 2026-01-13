using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yt.SnapTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void DemoForm_Load(object sender, EventArgs e)
        {
            Win32.Hooks.SystemHotKey hotKey = new Win32.Hooks.SystemHotKey(this.Handle);
            hotKey.AddHotKey(7549, Win32.KeyModifiers.Ctrl, Keys.A, 
                () => { 截图ToolStripMenuItem_Click(null, null); }
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void 截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreenCapturer.Wait.Delay(200);
            ScreenCapturer.ScreenCapturerTool screenCapturer = new ScreenCapturer.ScreenCapturerTool();
            if (screenCapturer.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.BackgroundImage = screenCapturer.Image;
                Bitmap bitmap = screenCapturer.Image as Bitmap;
                Color color = bitmap.GetPixel(1,1);
                textBox1.Text = $"{color.R},{color.G},{color.B}";
                textBox2.Text = $"#{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
            }
            this.Show();
        }

        private void 截屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreenCapturer.Wait.Delay(200);
            pictureBox1.BackgroundImage = ScreenCapturer.ImageHelper.GetScreenCapture();
            this.Show();

        }

        private void 区域截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreenCapturer.Wait.Delay(200);
          var bmp=  ScreenCapturer.ImageHelper.GetScreenCapture();

            pictureBox1.BackgroundImage = ScreenCapturer.ImageHelper.GetRectBitmap(bmp,new Rectangle(0,0,300,300));

            this.Show();
        }

      
    }
}
