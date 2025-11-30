using CricketSimulator.Interfaces;
using CricketSimulator.Repositories;
using CricketSimulator.Services;

public class StartUp
{
    IConfiguration configuration;
    public StartUp(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.Add(new ServiceDescriptor(
            typeof(IMongoClientHelper),
            typeof(MongoClientHelper),
            ServiceLifetime.Singleton
            ));
        services.Add(new ServiceDescriptor(
            typeof(ITeamRepository),
            typeof(TeamRepository),
            ServiceLifetime.Transient
        ));
        services.Add(new ServiceDescriptor(
            typeof(ITeamsService),
            typeof(TeamsService),
            ServiceLifetime.Transient
        ));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}