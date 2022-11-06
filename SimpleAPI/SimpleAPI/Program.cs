global using System.Linq;
var Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hi", () => "Hello C# 10");
app.MapGet("/weather", (Func <WeatherForecast[]>)GetForecasts);
app.MapGet("/weather2", ()=>GetForecasts);

WeatherForecast[] GetForecasts()
{
	var rng = new Random();

	return Enumerable.Range(1, 5)
		.Select(index => new WeatherForecast
		(
			DateTime.Now.AddDays(index),
			rng.Next(-20, 55),
			9,
			Summaries[rng.Next(Summaries.Length)]
		)).ToArray();
/*	{
		Date = DateTime.Now.AddDays(index),
		TemperatureC = rng.Next(-20, 55),
		//TemperatureF = 9,
		Summary = Summaries[rng.Next(Summaries.Length)],
	}).ToArray();*/
}
app.Run();
record WeatherForecast(DateTime Date, int TemperatureC, int TemperatureF, string Summary);
