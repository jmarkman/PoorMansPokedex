using System.Net;
using System.Net.Http;
using System.Text;
using Moq;
using Moq.Protected;

namespace PoorMansPokedex.Test.MockingTools;

public sealed class MockedHttpClient : IDisposable
{
    private MockedHttpClient(HttpClient client, Mock<HttpMessageHandler> handlerMock)
    {
        this.Client = client;
        this.HandlerMock = handlerMock;
    }

    public HttpClient Client { get; }

    public Mock<HttpMessageHandler> HandlerMock { get; }

    public static MockedHttpClient Create(
        HttpStatusCode statusCode = HttpStatusCode.OK,
        string jsonBody = "{}",
        Func<HttpRequestMessage, bool>? requestMatcher = null,
        Uri? baseAddress = null)
    {
        var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        handlerMock.Protected()
            .Setup("Dispose", ItExpr.IsAny<bool>());
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(request =>
                    requestMatcher == null || requestMatcher(request)),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(() => new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
            });

        var client = new HttpClient(handlerMock.Object)
        {
            BaseAddress = baseAddress ?? new Uri("https://pokeapi.co/api/v2/")
        };

        return new MockedHttpClient(client, handlerMock);
    }

    public void Dispose()
    {
        this.Client.Dispose();
    }
}
