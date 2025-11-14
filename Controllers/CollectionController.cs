using Microsoft.AspNetCore.Mvc;
using sprinklrGcs.Models;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class CollectionController : ControllerBase
{
    private readonly IGeocoderClient _geocoderClient;

    public CollectionController(IGeocoderClient geocoderClient)
    {
        _geocoderClient = geocoderClient;
    }

    [HttpPost("forward")]
    public async Task<ActionResult> Forward([FromBody] ExternalRequest request)
    {
        var jsonResult = await _geocoderClient.ForwardRequestAsync(request);
        return Content(jsonResult, "application/json");
    }
}