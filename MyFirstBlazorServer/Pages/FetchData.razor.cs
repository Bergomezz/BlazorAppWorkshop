using MyFirstBlazorServer.Data;

namespace MyFirstBlazorServer.Pages;

public partial class FetchData
{
  private WeatherForecast[]? forecasts;

  protected override async Task OnInitializedAsync()
  {
    forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
  }
}