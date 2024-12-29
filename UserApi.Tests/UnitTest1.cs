using Microsoft.AspNetCore.Mvc.Testing;


namespace UserApi.Tests;

public class BasicTests : IClassFixture<WebApplicationFactory<Program>>
{

    private readonly WebApplicationFactory<Program> _factory;

    public BasicTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task getAllUsers_ReturnOkResult()
    {
        HttpClient client = _factory.CreateClient();

        var response = await client.GetAsync("/users");

        response.EnsureSuccessStatusCode();
    }
}
