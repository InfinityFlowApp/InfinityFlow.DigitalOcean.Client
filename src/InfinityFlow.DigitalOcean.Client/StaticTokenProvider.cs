using Microsoft.Kiota.Abstractions.Authentication;

namespace InfinityFlow.DigitalOcean.Client;

public class StaticTokenProvider(string Token) : IAccessTokenProvider
{
    AllowedHostsValidator IAccessTokenProvider.AllowedHostsValidator => new();
    public Task<string> GetAuthorizationTokenAsync(Uri requestUri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default) => Task.FromResult(Token);
}
