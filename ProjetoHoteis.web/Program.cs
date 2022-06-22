using ProjetoHoteis.lib.Data;
using Microsoft.EntityFrameworkCore;
using ProjetoHoteis.lib.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddScoped<EstadiaRepositorio>();
builder.Services.AddScoped<HospedeRepositorio>();
builder.Services.AddScoped<HotelRepositorio>();
builder.Services.AddScoped<QuartoRepositorio>();
builder.Services.AddScoped<ServicoRepositorio>();
builder.Services.AddScoped<TipoDeQuartoRepositorio>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HoteisContext>(
conn =>
conn.UseNpgsql(builder.Configuration.GetConnectionString("HoteisDB"))
.UseSnakeCaseNamingConvention()
);

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
