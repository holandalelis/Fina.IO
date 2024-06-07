using Fina.Api.Data;
using Fina.Api.Handlers;
using Fina.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string ConnectionString = "Server=localhost,1433;Database=fina;User Id=sa;Password=PedroAdmin@0301;Trusted_Connection=False; TrustServerCertificate=True;";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(ConnectionString, options => options.EnableRetryOnFailure()));

builder.Services.AddTransient<ITransactionHandler, TransactionHandler>();
builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();