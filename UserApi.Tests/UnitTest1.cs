using Microsoft.AspNetCore.Mvc.Testing;


namespace UserApi.Tests;

public class BasicTests : IClassFixture<WebApplicationFactory<Program>>
{

    private readonly WebApplicationFactory<Program> _factory;

    public BasicTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }
}
