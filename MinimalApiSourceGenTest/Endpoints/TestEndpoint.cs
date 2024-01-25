namespace MinimalApiSourceGenTest.Endpoints;

public class TestEndpoint : IEndpoint
{
    public void MapEndpoints(IEndpointRouteBuilder app)
    {
        app.MapGet("/test", () => "Hello, World!");
    }
}
