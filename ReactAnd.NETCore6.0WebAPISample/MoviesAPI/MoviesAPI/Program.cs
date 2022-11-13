using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
	//ここで、データベース コンテキストを組み込みの IOC コンテナーに登録し、CORS ポリシーを に追加して、UI が Web API 要求にアクセスできるようにします。次のコードを Program.cs に追加します。
	builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddDbContext<MovieContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
