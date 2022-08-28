using System;

namespace App.Services;

public class EmailService
{
    public void OnImageProcessed(object source, ImageEventArgs e)
    {
        Console.WriteLine($"Email service: message sent for {e.Image.Name} image...");
    }
}