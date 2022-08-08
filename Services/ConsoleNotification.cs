using System;

namespace dependencyinjection.Services
{
    public class ConsoleNotification
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"ConsoleNotification.SendMessage called. Message: {message}");
        }
    }
}