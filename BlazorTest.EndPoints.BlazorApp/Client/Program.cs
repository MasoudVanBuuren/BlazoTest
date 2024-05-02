using BlazorTest.Domain.Contracts.WebAppContracts;
using BlazorTest.EndPoints.BlazorApp;
using BlazorTest.InfraStructure.DataAccess.Common;
using BlazorTest.InfraStructure.DataAccess.WebAppRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.EndPoints.BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddDbContext<BlazorTestDbContext>(options => options.UseSqlServer("name=ConnectionStrings:BlazorCS"));
            builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();
            builder.Services.AddScoped<IStatesRepository, StatesRepository>();
            builder.Services.AddScoped<ICitiesRepository, CitiesRepository>();
            await builder.Build().RunAsync();
        }
    }
}