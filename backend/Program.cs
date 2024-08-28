using Amazon.S3;
using backend.Context;
using backend.Models;
using backend.Repositories;
using backend.Services;
using backend.Services.AWSS3Client;
using backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Amazon.Extensions.NETCore.Setup;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//Registering Repositories
builder.Services.AddScoped<IBaseRepository<User>, UserRepository>();
builder.Services.AddScoped<IBaseRepository<Project>, ProjectRepository>();

//Regoistering Services
builder.Services.AddAWSService<IAmazonS3>();
builder.Services.AddScoped<IS3Service, S3Service>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SQLDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
