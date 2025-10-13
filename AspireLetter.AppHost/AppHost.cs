var builder = DistributedApplication.CreateBuilder(args);

// Add SQL Server container (named "identity-sql")
var db = builder.AddSqlServer("identity-sql")
                .AddDatabase("identitydb");

builder.AddProject<Projects.webapp>("webapp") // Remove Projects. if WebApp is directly in Projects namespace
       .WithReference(db);

builder.Build().Run();
