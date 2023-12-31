using MambuStudy.Application.Interfaces;
using MambuStudy.Application.Services;
using Microsoft.Net.Http.Headers;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IDepositProductService, DepositProductService>();
builder.Services.AddScoped<IDepositAccountService, DepositAccountService>();
builder.Services.AddScoped<IDepositTransactionService, DepositTransactionService>();

// Add HttpClient configuration
builder.Services.AddHttpClient(
    "mambuApi",
    configureClient =>
    {
        configureClient.BaseAddress = new Uri(builder.Configuration.GetSection("MambuApiConfiguration:BaseUrl").Value);
        configureClient.DefaultRequestHeaders.Add("apiKey", builder.Configuration.GetSection("MambuApiConfiguration:ApiKey").Value);
        configureClient.DefaultRequestHeaders.Add(HeaderNames.Accept, $"application/vnd.mambu.{builder.Configuration.GetSection("MambuApiConfiguration:Version").Value}+json");
        configureClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
    });

builder.Services.AddControllers()
    .AddJsonOptions(opt => { opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
