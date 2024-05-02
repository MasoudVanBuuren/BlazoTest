using BlazorAppServer.Data;
using BlazorTest.Domain.Contracts.WebAppContracts;
using BlazorTest.InfraStructure.DataAccess.Common;
using BlazorTest.InfraStructure.DataAccess.WebAppRepository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddDbContext<BlazorTestDbContext>(options => options.UseSqlServer("name=ConnectionStrings:BlazorCS"));
            builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();
            builder.Services.AddScoped<IStatesRepository, StatesRepository>();
            builder.Services.AddScoped<ICitiesRepository, CitiesRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}