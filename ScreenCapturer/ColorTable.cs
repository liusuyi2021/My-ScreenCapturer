using System.Drawing;

namespace ScreenCapturer
{   
    public class ColorTable
    {
        public virtual Color BorderColor => Color.FromArgb(65, 173, 236);
        public virtual Color BackColorNormal=> Color.FromArgb(66, 133, 244);
        public virtual Color BackColorHover=> Color.FromArgb(65, 173, 236);
        public virtual Color BackColorPressed=> Color.FromArgb(24, 142, 206);
        public virtual Color ForeColor => Color.FromArgb(12, 83, 124);
        
    }
}
