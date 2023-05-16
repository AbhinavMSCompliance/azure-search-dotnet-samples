using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsDefaults()
    .Build();

host.Run();
