using dependencyinjection.Interfaces;
using dependencyinjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dependencyinjection.Pages;

public class IndexModel : PageModel
{
    private readonly ConsoleNotification _consoleNotification;
    private readonly LoggingNotification _loggingNotification;

    public IndexModel(ConsoleNotification consoleNotification, LoggingNotification loggingNotification)
    {
        _consoleNotification = consoleNotification;
        _loggingNotification = loggingNotification;
    }

    public void OnGet()
    {
        _consoleNotification.SendMessage("IndexModel.OnGet");
        _loggingNotification.SendMessage("IndexModel.OnGet");
    }
}
