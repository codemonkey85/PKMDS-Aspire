var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.PKMDS_ApiService>("apiservice");

builder.AddProject<Projects.PKMDS_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
