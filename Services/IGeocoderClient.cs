using sprinklrGcs.Models;
using System.Threading.Tasks;

public interface IGeocoderClient
{
    Task<string> ForwardRequestAsync(ExternalRequest request);
}
