public class Startup {
    
    public Startup(IConfiguration configuration) 
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices (IServiceCollection services) 
    {
        services.AddRazorPages();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (en.IsDevelopment()) {
            app.UseDeveloperExceptioPage(); 
        }
        else {
            app.UseExpectionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(enpoints => {
            enpoints.MapRazorPages();
        });
    }
}