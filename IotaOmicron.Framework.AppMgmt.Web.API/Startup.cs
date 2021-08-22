using IotaOmicron.Framework.Data.Common;
using IotaOmicron.Framework.Data.Common.Config;
using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Repositories.Application.Classes;
using IotaOmicron.Framework.Repositories.Application.Interfaces;
using IotaOmicron.Framework.Services.Application.Classes;
using IotaOmicron.Framework.Services.Application.Interfaces;
using IotaOmicron.Framework.Utilities.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace IotaOmicron.Framework.AppMgmt.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
          .AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureAd"));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Iota Omicron Application Management REST API", Version = "v1", Description = "REST API abstraction of Application Management processes" });
            });
            services.AddTransient<ISqlHandler, SqlHandler>();
            services.AddTransient<IApplicationRepository, ApplicationRepository>();
            services.AddTransient<IApplicationService, ApplicationService>();

            var appManagementKeyVaultName = Configuration.GetValue<string>("KeyVaultName");
            IKeyVaultConfig keyVaultConfig = new KeyVaultConfig(appManagementKeyVaultName);
            services.AddSingleton(keyVaultConfig);

            var appManagementConfig = new AppManagementConfig(keyVaultConfig);
            services.AddSingleton(appManagementConfig);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IotaOmicron.Framework.AppMgmt.Web.API v1"));
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware<ResponseBuilder>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
