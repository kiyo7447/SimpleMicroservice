using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
	//�����ŁA�f�[�^�x�[�X �R���e�L�X�g��g�ݍ��݂� IOC �R���e�i�[�ɓo�^���ACORS �|���V�[�� �ɒǉ����āAUI �� Web API �v���ɃA�N�Z�X�ł���悤�ɂ��܂��B���̃R�[�h�� Program.cs �ɒǉ����܂��B
	builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddDbContext<MovieContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
