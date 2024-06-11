using Application.Services;
using Application.Services.Interfaces;
using Domain.Repositories;
using Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());
});


builder.Services.AddTransient<ISolicitacaoService, SolicitacaoService>();
builder.Services.AddTransient<ISolicitacaoRepository, SolicitacaoRepository>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAll");
app.UsePathBase(builder.Configuration["App:Pathbase"]);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
