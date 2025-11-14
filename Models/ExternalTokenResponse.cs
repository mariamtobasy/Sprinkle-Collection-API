using System.Text.Json.Serialization;

namespace sprinklrGcs.Models

{

    public class ExternalTokenResponse

    {

        [JsonPropertyName("access_token")]

        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]

        public string RefreshToken { get; set; }

        [JsonPropertyName("token_type")]

        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]

        public int ExpiresIn { get; set; }

    }

}


namespace sprinklrGcs.Options

{

    public class ExternalApiOptions

    {

        public string BaseUrl { get; set; }

    }

}

