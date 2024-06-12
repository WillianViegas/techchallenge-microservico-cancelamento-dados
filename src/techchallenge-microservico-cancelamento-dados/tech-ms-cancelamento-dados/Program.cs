using Application.Services;
using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Infra.DatabaseConfig;
using Infra.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());
});


builder.Services.AddSingleton<MongoClient>(_ => new MongoClient());
builder.Services.AddSingleton<IMongoDatabase>(provider => provider.GetRequiredService<MongoClient>().GetDatabase("ExclusaoDadosDb"));
builder.Services.AddSingleton<IMongoCollection<Solicitacao>>(provider => provider.GetRequiredService<IMongoDatabase>().GetCollection<Solicitacao>("Solicitacao"));


builder.Services.AddTransient<ISolicitacaoService, SolicitacaoService>();
builder.Services.AddTransient<ISolicitacaoRepository, SolicitacaoRepository>();
builder.Services.Configure<DatabaseConfig>(builder.Configuration.GetSection(nameof(DatabaseConfig)));
builder.Services.AddSingleton<IDatabaseConfig>(sp => sp.GetRequiredService<IOptions<DatabaseConfig>>().Value);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(opts => opts.EnableAnnotations());

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowAll");
app.UsePathBase(builder.Configuration["App:Pathbase"]);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
