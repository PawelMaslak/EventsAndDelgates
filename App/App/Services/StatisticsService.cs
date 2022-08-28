using System;

namespace App.Services;

public class StatisticsService
{
    public void OnImageProcessed(object source, ImageEventArgs e)
    {
        Console.WriteLine($"Statistics Service: Image has been processed in {e.ProcessTime} ms...");
    }
}