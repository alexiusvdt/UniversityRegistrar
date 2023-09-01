ConfigureServices(IServiceCollection services) {

	// In production, the React files will be served from this directory
    services.AddSpaStaticFiles(configuration => {
        configuration.RootPath = "ClientApp/build";
    });
}

Configure(IApplicationBuilder app, IWebHostEnvironment env) {
	
    // After app.UseStaticFiles()
	app.UseSpaStaticFiles();
 	
	// After app.UseEndpoints()
	app.UseSpa(spa => {
      spa.Options.SourcePath = "ClientApp";
      if (env.IsDevelopment()) {
        spa.UseReactDevelopmentServer(npmScript: "start");
      }
    });
}