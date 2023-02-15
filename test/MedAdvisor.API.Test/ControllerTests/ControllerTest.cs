/**using System.Text.Json;
using System.Net;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;

public class UserRegistrationController : IClassFixture<TestingWebAppFactory<Program>>
{
    private readonly HttpClient _client;

    public UserRegistrationController(TestingWebAppFactory<Program> factory)
        => _client = factory.CreateClient();


    [Fact]
    public async Task Register_Returns_ok()
    {

        // Arrange
        var new_user = new
        {
            Email = "user1@example.com",
            Password = "usser11234",
            ConfirmPassword = "usser11234",
            
        };

        var content = new StringContent(
            JsonSerializer.Serialize(new_user), System.Text.Encoding.UTF8, "application/json");

        //Act
        var response = await _client.PostAsync("/api/register", content);

        //assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Register_Returns_BadRequest()
    {

        // Arrange
        var new_user = new
        {
            Email = "user@example.com",
            Password = "string",
            ConfirmPassword = "string",


        };

        var content = new StringContent(
            JsonSerializer.Serialize(new_user), System.Text.Encoding.UTF8, "application/json");

        //Act
        var response = await _client.PostAsync("/api/register", content);

        //assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }


    [Fact]
    public async Task Login_Returns_ok()
    {

        // Arrange
        var login = new { email = "user@example.com", password = "string" };
        var content = new StringContent(
            JsonSerializer.Serialize(login), System.Text.Encoding.UTF8, "application/json");

        //Act
        var response = await _client.PostAsync("/api/login", content);

        //assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }



    [Fact]
    public async Task Login_Returns_BadRequest()
    {

        // Arrange
        var login = new { email = "Wrong@example.com", password = "string" };
        var content = new StringContent(
            JsonSerializer.Serialize(login), System.Text.Encoding.UTF8, "application/json");

        //Act
        var response = await _client.PostAsync("/api/user/Auth/login", content);

        //assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

}
*/