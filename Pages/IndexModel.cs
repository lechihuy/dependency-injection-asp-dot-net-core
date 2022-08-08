using dependencyinjection.Interfaces;
using dependencyinjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dependencyinjection.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly INotification _notification;

    public IndexModel(ILogger<IndexModel> logger, INotification notification)
    {
        _logger = logger;
        _notification = notification;
    }

    public void OnGet()
    {
        _notification.SendMessage("IndexModel.OnGet");
    }
}
