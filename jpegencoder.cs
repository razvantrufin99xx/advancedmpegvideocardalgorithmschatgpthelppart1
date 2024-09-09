Sure! Here's a simple example of how to encode and decode a JPEG image using C#:

### Encoding a JPEG Image

```csharp
using System;
using System.IO;
using System.Windows.Media.Imaging;

class Program
{
    static void Main()
    {
        int width = 128;
        int height = width;
        int stride = width / 8;
        byte[] pixels = new byte[height * stride];

        // Define the image palette
        BitmapPalette myPalette = BitmapPalettes.Halftone256;

        // Create a new empty image with the pre-defined palette
        BitmapSource image = BitmapSource.Create(
            width, height, 96, 96, PixelFormats.Indexed1, myPalette, pixels, stride);

        using (FileStream stream = new FileStream("new.jpg", FileMode.Create))
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            encoder.Save(stream);
        }

        Console.WriteLine("JPEG image saved successfully.");
    }
}
```

### Decoding a JPEG Image

```csharp
using System;
using System.IO;
using System.Windows.Media.Imaging;

class Program
{
    static void Main()
    {
        using (FileStream imageStreamSource = new FileStream("tulipfarm.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            JpegBitmapDecoder decoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource = decoder.Frames[0];

            // Use the decoded image (e.g., display it in a WPF Image control)
            // Image myImage = new Image();
            // myImage.Source = bitmapSource;
        }

        Console.WriteLine("JPEG image decoded successfully.");
    }
}
```

This code demonstrates how to create a simple JPEG image and save it to a file, as well as how to read and decode a JPEG image from a file¹.

If you have any specific requirements or need further assistance, feel free to ask!

Sursă: conversație cu Copilot. 9/9/2024
(1) How to: Encode and decode a JPEG image - WPF .NET Framework. https://learn.microsoft.com/en-us/dotnet/desktop/wpf/graphics-multimedia/how-to-encode-and-decode-a-jpeg-image?view=netframeworkdesktop-4.8.
(2) A Simple JPEG Encoder in C# - CodeProject. https://www.codeproject.com/articles/83225/a-simple-jpeg-encoder-in-c.
(3) How to covert RAW data into JPEG file - CodeProject. https://www.codeproject.com/questions/786166/how-to-covert-raw-data-into-jpeg-file.
(4) Image.Save Method (System.Drawing) | Microsoft Learn. https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image.save?view=net-8.0.
(5) GitHub - BitMiracle/libjpeg.net: LibJpeg.Net allows you to read and .... https://github.com/BitMiracle/libjpeg.net.
(6) JPEG decoder, encoder and optimizer implemented in C#.. https://github.com/yigolden/JpegLibrary.
(7) 方法: JPEG イメージのエンコードおよびデコード - WPF .NET Framework. https://learn.microsoft.com/ja-jp/dotnet/desktop/wpf/graphics-multimedia/how-to-encode-and-decode-a-jpeg-image?view=netframeworkdesktop-4.8.
(8) Converting Image to JPG in C# - webdevtutor.net. https://www.webdevtutor.net/blog/c-sharp-convert-image-to-jpg.
(9) undefined. https://www.nuget.org/packages/BitMiracle.LibJpeg.NET.
(10) undefined. http://www.bitmiracle.com.
(11) Getty Images. https://www.gettyimages.com/detail/photo/female-friends-enjoying-selfie-together-at-home-royalty-free-image/1496133008.