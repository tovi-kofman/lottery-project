using MyProject.DTO;
using MyProject.Entities;
using MyProject.Interface;
using MyProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LotteryService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ProductInLotteryService>();
builder.Services.AddScoped<TicketService>();
builder.Services.AddScoped<IDataContext, DataContext>();
builder.Services.AddControllers();
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