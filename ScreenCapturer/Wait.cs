using System;
using System.Windows.Forms;

namespace ScreenCapturer
{
        /// <summary>
        /// 时间相关类
        /// </summary>
        public static partial class Wait
        {
            /// <summary>
            /// 延时函数
            /// </summary>
            /// <param name="milliSecond">延时毫秒数</param>
            public static void Delay(uint milliSecond = 1000)
            {
                if (milliSecond <= 0) milliSecond = 0;
                int start = Environment.TickCount;
                while (Math.Abs(Environment.TickCount - start) < milliSecond)
                {
                    Application.DoEvents();
                    
                }
            }
    }
}
