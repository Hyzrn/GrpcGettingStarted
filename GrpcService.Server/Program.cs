using GrpcService.Server.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddHttpClient();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5002, listenOptions => listenOptions.Protocols = HttpProtocols.Http2);
    options.AddServerHeader = false;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<CommentService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();