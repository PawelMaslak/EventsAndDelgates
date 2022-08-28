using App.Models;
using App.Services;

namespace App
{
    /// <summary>
    /// This program allows user to easy understand the idea behind Events and Delegates.
    /// What are events?
    ///     Event is mechanism that allows communication between parts of the project.
    ///     It allows us to achieve loosely coupled application.
    ///     Allows to easily extend applications without risk of breaking something down.
    ///     The subscriber classes are waiting for event being sent by the publisher and process the event args.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageProcessor service = new ImageProcessor(); //publisher
            EmailService emailService = new EmailService(); //subscriber
            MessageService messageService = new MessageService(); //subscriber
            StatisticsService statisticsService = new StatisticsService(); //subscriber

            Image img = new Image { Name = "test.jpg" };

            service.ImageProcessed += emailService.OnImageProcessed;
            service.ImageProcessed += messageService.OnImageProcessed;
            service.ImageProcessed += statisticsService.OnImageProcessed;

            service.ProcessImage(img);
        }
    }
}
