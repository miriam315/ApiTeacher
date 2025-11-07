using School;
using School.Core.Repositories;
using School.Core.Service;
using School.Data.Repositories;
using School.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IDataContext, DataContext>();//יוצר  מופע לכל בקשה
//builder.Services.AddSingleton<IDataContext, DataContext>();//יוצר מופע אחד לכל האפליקציה
//builder.Services.AddTransient<IDataContext, DataContext>();//יוצר מופע חדש בכל פעם שיהיה רשום את הדרישה למופע

builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton<IStudentService, StudentService>();

builder.Services.AddDbContext<DataContext>();


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
