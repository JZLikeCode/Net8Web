using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Windy", "Boilings", "Drizzling", "Falling", "GitFalling", "Frozen", "Snowing"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    //smelly code test: long function name
    public bool FakeLongFunction1234567890(int value)
    {
        if (value > 0 && value % 2 == 0 || value < -10)
        {
            return true;
        }

        return false;
    }
    //smelly code test: same function
    public bool FakeLongFunctionABCDEFGHIGKLMNOPQRSTUVWSYZ(int value)
    {
        //logic check
        if (value > 0 && value % 2 == 0 || value < -10)
        {
            //return true
            return true;
        }
        //return false
        return false;
    }  

    //smelly code test
    public string InefficientStringConcatenation()
    {
        string result = "";
        for (int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }
        return result;
    }
}

//smelly code test: unused class
public class UnusedClass
{

}
