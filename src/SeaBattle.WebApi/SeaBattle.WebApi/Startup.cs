using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using SeaBattle.WebApi.Configurations;
using Newtonsoft.Json.Serialization;

namespace SeaBattle.WebApi
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            AutoMapperConfig.Initialize();
            RepositoriesConfig.Initialize(services);

            services.AddOptions();
            services.Configure<AppConfig>(Configuration.GetSection("App"));

            services.AddCors();

            services.AddMvc()
                .AddJsonOptions(opts => opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()); // Force Camel Case to JSON
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseMvc();
        }
    }
}
