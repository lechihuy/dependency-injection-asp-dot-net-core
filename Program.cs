using dependencyinjection.Interfaces;
using dependencyinjection.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServices();

// Service lifetimes testing
var provider = builder.Services.BuildServiceProvider();
for (int n = 0; n < 2; n++) {
    using (var scope = provider.CreateScope()) {
        Console.WriteLine($"Scope: {n}");
        
        for (int i = 0; i < 5; i++)
        {
            var service = scope.ServiceProvider.GetRequiredService<INotification>();
            Console.WriteLine($"\tRequest {i}: {service.GetHashCode()}");
        } 
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
