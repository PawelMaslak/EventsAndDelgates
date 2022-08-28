using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using App.Models;

namespace App.Services
{
    /// <summary>
    /// Custom event args that allow developer to put whatever they like for the event handlers.
    /// </summary>
    public class ImageEventArgs : EventArgs
    {
        public Image Image { get; set; }
        public string ProcessTime { get; set; }
    }
    /// <summary>
    /// This is the Publisher class that mocks the processing of the image.
    /// </summary>
    public class ImageProcessor
    {
        public delegate void ImageProcessedEventHandler(object source, ImageEventArgs args);

        public event ImageProcessedEventHandler ImageProcessed;

        public void ProcessImage(Image image)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Processing image...");
            Thread.Sleep(3000);
            stopwatch.Stop();

            OnImageProcessed(image, stopwatch.ElapsedMilliseconds);
        }

        protected virtual void OnImageProcessed(Image image, long elapsedMilliseconds)
        {
            if (ImageProcessed != null)
            {
                ImageProcessed(this, new ImageEventArgs() {Image = image, ProcessTime = elapsedMilliseconds.ToString()});
            }
        }
    }
}
