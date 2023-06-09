using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Nuñez_Inmobiliaria.Data;
using Nuñez_Inmobiliaria.Data.Context;
using Nuñez_Inmobiliaria.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<NunezInmobiliariaDbContext>();
builder.Services.AddScoped<INunezInmobiliariaDbContext, NunezInmobiliariaDbContext>();
builder.Services.AddScoped<IClienteSevices, ClienteSevices>();
builder.Services.AddScoped<IAlquilerServices, AlquilerServices>();
builder.Services.AddScoped<IInmuebleServices, InmuebleServices>();



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
