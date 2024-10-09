using KeypadPhoneConverter.Infrastructure.Interfaces;
using KeypadPhoneConverter.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddTransient<IKeypadService, KeypadService>();
        services.AddTransient<IInputService, InputService>();
        services.AddTransient<IOutputService, OutputService>();

        services.AddTransient<App>();
    }).Build();

var app = host.Services.GetRequiredService<App>();
app.Run();