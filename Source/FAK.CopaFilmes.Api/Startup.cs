using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Filters;
using FAK.CopaFilmes.Api.Infraestrutura;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FAK.CopaFilmes.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("copapolicy",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddControllers();
            services.AddApiVersioning();

            services.AddTransient<ICampeonato, Campeonato>();

            services.AddHttpClient<EmpresaApiCliente>(options =>
            {
                options.BaseAddress = new System.Uri("http://copafilmes.azurewebsites.net/");
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(new ErroRespostaFiltro());
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("copapolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
