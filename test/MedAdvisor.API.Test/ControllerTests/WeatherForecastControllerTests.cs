using MedAdvisor.Common.Test;
using Xunit;
using MedAdvisor.Api;
using MedAdvisor.API.Test.Infrastructure;
using FluentAssertions;
using System.Net;
namespace MedAdvisor.API.Test.ControllerTests
{
    public class WeatherForecastControllerTests : IClassFixture<TestWebApplicationFactory<Startup>>
    {
        private readonly TestWebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;
        private readonly IServiceProvider _serviceProvider;
        public WeatherForecastControllerTests(TestWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _serviceProvider = factory.Services;

        }


        [Fact]
        public async Task WeatherForecastController_WeatherForecast_Get()
        {
            var (httpStatusResponse, httpResponseBody) = await _client.ExecuteWithFullResultAsync<IEnumerable<WeatherForecast>>(
                HttpMethod.Get,
                $"/WeatherForecast",
                string.Empty

            );
            Assert.Equal(HttpStatusCode.OK, httpStatusResponse);
            httpResponseBody.Should().NotBeEmpty().And.HaveCount(5);
        }
        [Fact]
        public async Task WeatherForecastController_About_OK()
        {
            var (httpStatusResponse, httpResponseBody) = await _client.ExecuteWithFullResultAsync<Task>(
                HttpMethod.Get,
                $"/WeatherForecast/About?stat={1}",
                string.Empty

            );
            Assert.Equal(HttpStatusCode.OK, httpStatusResponse);

        }

        /*  [Fact]
         public async Task WeatherForecastController_About_NotFound()
         {
             var httpStatusResponse = await _client.ExecuteAsync(
                HttpMethod.Get,
                $"/WeatherForecast/About?stat={10}",
                string.Empty

            );
             Assert.Equal(HttpStatusCode.NotFound, httpStatusResponse);

         } */

    }
}