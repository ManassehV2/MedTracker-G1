using FluentAssertions;
using MedAdvisor.Api;
using MedAdvisor.API.Test.Infrastructure;
using MedAdvisor.Common.Test;
using MedAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class DiagnoseTest : IClassFixture<TestWebApplicationFactory<Startup>>
    {
        private readonly TestWebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;
        private readonly IServiceProvider _serviceProvider;
        public DiagnoseTest(TestWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _serviceProvider = factory.Services;

        }


        [Fact]
        public async Task DiagnoseTestGetDiagnoses()
        {
            var (httpStatusResponse, httpResponseBody) = await _client.ExecuteWithFullResultAsync<IEnumerable<Diagnose>>(
                HttpMethod.Get,
                $"/Diagnose",
                string.Empty

            );
            Assert.Equal(HttpStatusCode.OK, httpStatusResponse);
            httpResponseBody.Should().NotBeEmpty().And.HaveCount(5);
        }
    }
}

