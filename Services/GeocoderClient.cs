using Microsoft.Extensions.Options;
using sprinklrGcs.Models;
using sprinklrGcs.Options;
using System.Net.Http.Headers;
using System.Net.Http.Json;
public class GeocoderClient : IGeocoderClient
{
    private readonly HttpClient _httpClient;
    private readonly ExternalApiOptions _options;

    public GeocoderClient(HttpClient httpClient, IOptions<ExternalApiOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<string> ForwardRequestAsync(ExternalRequest request)
    {
        // Set headers
        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        //_httpClient.DefaultRequestHeaders.Add("x-api-key", _options.ApiKey);

        // Send POST request
        var response = await _httpClient.PostAsJsonAsync(_options.BaseUrl, request);

        // Return raw JSON string
        return await response.Content.ReadAsStringAsync();
    }
}
