var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.MuddiestMoment_Api>("mmi-api");

var gateway = builder.AddProject<Projects.Gateway_Api>("gateway")
    .WithReference(mmApi)
    .WaitFor(mmApi);

builder.Build().Run();

