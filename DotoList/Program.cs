using DotoList.Interfaces;
using TodoListCore.Models;
using TodoListCore.Services;
using TodoListServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//כאן מזריקדים את התלות של הממשק
builder.Services.AddScoped<IMsg, SmsService>();
builder.Services.AddScoped<IBabyRepository, BabyService>();
builder.Services.AddSingleton<DataContext>();
//builder.Services.AddTransient<IMsg, SmsService>();

// Add CORS services and define a policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        policy =>
        {
            policy.AllowAnyOrigin() // מאפשר לכל דומיין
                   .AllowAnyHeader() // מאפשר כל Header
                   .AllowAnyMethod();
        });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAnyOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
