using Equipos.DATOS.Repositorios;
using Equipos.NEGOCIO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICalculo, Calculo2>();
builder.Services.AddScoped<ISeleccionesRepositorio,SeleccionesRepositorio>();
builder.Services.AddScoped<ISeleccionesNegocio, SeleccionesNegocio>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
