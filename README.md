

#### 介绍
一个NET 下的截图工具，支持多屏幕下的截图功能。
本项目支持以下框架：

```
net40;net45;net451;net452;net46;net461;net462;net47;net471;net472;net48;
netcoreapp3.1;
net5.0-windows;net6.0-windows;net7.0-windows

```
使用示例：

```
ScreenCapturer.ScreenCapturerTool screenCapturer = new ScreenCapturer.ScreenCapturerTool();
if (screenCapturer.ShowDialog() ==  DialogResult.OK)
{
  var bmp = screenCapturer.Image;
}

```
自动截全屏：
```
var bmp= ScreenCapturer.ImageHelper.GetScreenCapture();

```

指定区域截取：

```
var bmp= ScreenCapturer.ImageHelper.GetScreenCapture();
Rectangle rect=new Rectangle(0,0,300,300);
 var cutbmp= ScreenCapturer.ImageHelper.GetRectBitmap(bmp,rect);

```

