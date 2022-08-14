using System;
using dependencyinjection.Interfaces;

namespace dependencyinjection.Services
{
    public class LoggingNotification : INotification, IDisposable
    {
        private readonly ILogger<LoggingNotification> _logger;

        private bool _disposed;

        public LoggingNotification(ILogger<LoggingNotification> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string message)
        {
            _logger.LogInformation($"LoggingNotification.SendMessage called. Message: {message}");
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            Console.WriteLine("LoggingNotification.Dispose");
            _disposed = true;
        }
    }
}