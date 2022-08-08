using System;
using dependencyinjection.Interfaces;

namespace dependencyinjection.Services
{
    public class LoggingNotification : INotification
    {
        private readonly ILogger<LoggingNotification> _logger;

        public LoggingNotification(ILogger<LoggingNotification> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string message)
        {
            _logger.LogInformation($"LoggingNotification.SendMessage called. Message: {message}");
        }
    }
}