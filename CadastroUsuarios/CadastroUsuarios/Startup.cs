using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CadastroUsuarios.Dtos;
using CadastroUsuarios.Entities;
using CadastroUsuarios.Interfaces;
using CadastroUsuarios.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroUsuarios
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
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddSwaggerGen(config => 
            {
                config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Usuarios Api", Version = "v1" });
            });
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();

            services.AddCors();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {          
            AutoMapper.Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<Usuarios, UsuariosDto>().ReverseMap();
            });

            app.UseSwagger();
            app.UseSwaggerUI(config => {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Usuarios Api");
            });

            app.UseCors(builder =>
                builder.WithOrigins("https://localhost:44347/"));

            app.UseMvc();
        }
    }
}
