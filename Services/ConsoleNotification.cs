using System;
using dependencyinjection.Interfaces;

namespace dependencyinjection.Services
{
    public class ConsoleNotification : INotification, IDisposable
    {
        private bool _disposed;

        public void SendMessage(string message)
        {
            Console.WriteLine($"ConsoleNotification.SendMessage called. Message: {message}");
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            Console.WriteLine("ConsoleNotification.Dispose");
            _disposed = true;
        }
    }
}