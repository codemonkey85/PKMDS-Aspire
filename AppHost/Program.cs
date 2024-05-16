var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.PKMDS_Aspire_ApiService>("apiservice");

builder.AddProject<Projects.PKMDS_Aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
