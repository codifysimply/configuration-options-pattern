using Config.Demo.WebApi.Config;
using Config.Demo.WebApi.Services;
using Config.Demo.WebApi.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;

namespace Config.Demo.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //var baseAddress = builder.Configuration["ApiConfig:BaseAddress"];
            //var userAgent = builder.Configuration["ApiConfig:UserAgent"];
            //var timeoutInSeconds = builder.Configuration["ApiConfig:TimeoutInSeconds"];

            var configuration = builder.Configuration;
            builder.Services.Configure<ApiConfig>(configuration.GetSection(nameof(ApiConfig)));

            builder.Services.AddTransient<ITransientService, TransientService>();
            builder.Services.AddScoped<IScopedService, ScopedService>();
            builder.Services.AddSingleton<ISingletonService, SingletonService>();
            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}