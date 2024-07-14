var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

var app = builder.Build();

app.MapGet("/", () => "Hello World from Fesor Dev!!!");

//- dotnet test --no-build --verbosity normal

app.Run();
