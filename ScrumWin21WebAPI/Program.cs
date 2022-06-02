using Microsoft.EntityFrameworkCore;
using ScrumWin21WebAPI.BLL;
using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Services;
using ScrumWin21WebAPI.DAL;
using ScrumWin21WebAPI.DAL.Data;
using ScrumWin21WebAPI.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SqlContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sql")));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IBusinessLogicLayer, BusinessLogicLayer>();
builder.Services.AddScoped<IDataAccessLayer, DataAccessLayer>();


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

app.UseCors(x => x.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
