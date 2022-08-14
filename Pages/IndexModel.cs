using dependencyinjection.Interfaces;
using dependencyinjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dependencyinjection.Pages;

public class IndexModel : PageModel
{
    private readonly INotification _notification;

    public IndexModel(INotification notification, IEnumerable<INotification> notifications)
    {
        Console.WriteLine($"notification is LoggingNotification: {notification is LoggingNotification}");

        var dependencyArray = notifications.ToArray();

        Console.WriteLine($"dependencyArray[0] is ConsoleNotification: {dependencyArray[0] is ConsoleNotification}");
        Console.WriteLine($"dependencyArray[1] is LoggingNotification: {dependencyArray[1] is LoggingNotification}");

        _notification = notification;
    }

    public void OnGet()
    {
        _notification.SendMessage("IndexModel.OnGet");
    }
}
