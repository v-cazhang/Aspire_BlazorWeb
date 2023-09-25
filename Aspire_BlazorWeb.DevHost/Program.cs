var builder = CloudApplication.CreateBuilder(args);

builder.AddProject<Aspire_BlazorWeb.DevHost.Projects.BlazorApp1>();

builder.Build().Run();
