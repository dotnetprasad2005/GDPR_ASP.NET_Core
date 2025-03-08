public void ConfigureServices(IServiceCollection services)
{
   services.Configure<CookiePolicyOptions>(options =>
   {
     options.CheckConsentNeeded = context => true;
      options.MinimumSameSitePolicy = SameSiteMode.None; 
   }); 
} 
