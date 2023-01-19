using Baigiamasis_darbas.Database;
using Baigiamasis_darbas.Database.Repositories;
using Baigiamasis_darbas.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserAddressRepository, UserAddressRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserInfoRepository, UserInfoRepository>();

builder.Services.AddDbContext<DatabaseContext>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString
    ("Database")));

var allowAll = "_allowAll";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowAll,
                      build =>
                      {
                          build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                      });
});
var app = builder.Build();

app.UseCors(allowAll);
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
