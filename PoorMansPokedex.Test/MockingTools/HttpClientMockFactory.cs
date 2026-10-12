using System.Net.Http;
using Moq;
using Moq.Protected;

namespace PoorMansPokedex.Test.MockingTools;

public static class HttpClientMockFactory
{
    public static HttpClient CreateHttpClient(
        out Mock<HttpMessageHandler> handlerMock,
        params HttpResponseMessage[] responses)
    {
        ArgumentNullException.ThrowIfNull(responses);

        if (responses.Length == 0)
        {
            throw new ArgumentException("At least one response must be provided.", nameof(responses));
        }

        if (responses.Any(response => response is null))
        {
            throw new ArgumentException("Responses cannot contain null values.", nameof(responses));
        }

        var responseQueue = new Queue<HttpResponseMessage>(responses);
        handlerMock = new Mock<HttpMessageHandler>();
        handlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Returns((HttpRequestMessage _, CancellationToken _) =>
                Task.FromResult(responseQueue.Dequeue()));

        return new HttpClient(handlerMock.Object);
    }
}
