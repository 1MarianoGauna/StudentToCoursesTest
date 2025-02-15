using CoursesAndStudents.Business;
using CoursesAndStudents.Datos.ConnectionDB;
using CoursesAndStudents.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IStudentsBusiness, StudentBusiness>();
builder.Services.AddScoped<ICoursesBusiness, CoursesBusiness>();
builder.Services.AddScoped<IStudentAndCourseBusiness, StudentAndCourseBusiness>();
builder.Services.AddScoped<IConnectionDB, ConnectionDB>();

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
