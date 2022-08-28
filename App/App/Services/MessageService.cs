using System;

namespace App.Services;

public class MessageService
{
    public void OnImageProcessed(object source, ImageEventArgs e)
    {
        Console.WriteLine($"Message service: text sent for {e.Image.Name} image...");
    }
}