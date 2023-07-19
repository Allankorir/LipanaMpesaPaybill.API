using LipanaMpesaPaybill.API.Core.Helper;
using LipanaMpesaPaybill.API.Core.Services;
using LipanaMpesaPaybill.API.Infrastructure.Data;
using LipanaMpesaPaybill.API.Infrastructure.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//dbbcontext

builder.Services.AddDbContext<PaybillDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaybillConnectionString"));
});

builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

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
