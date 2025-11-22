public class StartUp
{
    IConfiguration configuration;
    public StartUp(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        
    }

    public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
    {
    }
}