namespace SimpleAPI.Test;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging.Abstractions;

public class UnitTest1
{
    private readonly WeatherForecastController controller = new WeatherForecastController(
        new NullLogger<WeatherForecastController>()
    );

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("14/08/2023", returnValue.Date.ToString("dd/MM/yyyy"));
    }
}