using IotaOmicron.Framework.Data.Common.Config;
using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Repositories.External.Banxico.Classes;
using IotaOmicron.Framework.Repositories.External.Banxico.Interfaces;
using IotaOmicron.Framework.Repositories.External.DiarioOficialFederacion.Classes;
using IotaOmicron.Framework.Repositories.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Services.External.Banxico.Classes;
using IotaOmicron.Framework.Services.External.Banxico.Interfaces;
using IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Classes;
using IotaOmicron.Framework.Services.External.DiarioOficialFederacion.Interfaces;
using IotaOmicron.Framework.Utilities.Common.Classes.HttpClient;
using IotaOmicron.Framework.Utilities.Common.Interfaces;
using IotaOmicron.Framework.Utilities.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace IotaOmicron.Framework.GobMx.Web.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IotaOmicron.Framework.GobMx.Web.API", Version = "v1", Description = "REST API abstraction of Mexican government public API's" });
            });

            services.AddTransient<IBanxicoRepository, BanxicoRepository>();
            services.AddTransient<IDOFRepository, DOFRepository>();
            services.AddTransient<IBanxicoService, BanxicoService>();
            services.AddTransient<IDOFService, DOFService>();
            services.AddTransient<IHttpCustomClient, HttpCustomClient>();

            var banxicoToken        = new BanxicoToken();
            banxicoToken.HeaderName = Configuration["Banxico:Token:HeaderName"];
            banxicoToken.APIKey     = Configuration["Banxico:Token:APIKey"];

            IBanxicoConfig banxicoConfig = new BanxicoConfig(banxicoToken);
            banxicoConfig.BaseUri        = Configuration["Banxico:BaseUriSeries"];
            services.AddSingleton(banxicoConfig);

            IDiarioOficialFederacionConfig diarioOficialFederacionConfig = new DiarioOficialFederacionConfig();
            diarioOficialFederacionConfig.BaseUri                        = Configuration["DiarioOficialFederacion:BaseUri"];
            services.AddSingleton(diarioOficialFederacionConfig);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IotaOmicron.Framework.GobMx.Web.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseMiddleware<ResponseBuilder>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
