using System;
using dependencyinjection.Interfaces;

namespace dependencyinjection.Services
{
    public class ConsoleNotification : INotification
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"ConsoleNotification.WriteMessage called. Message: {message}");
        }
    }
}