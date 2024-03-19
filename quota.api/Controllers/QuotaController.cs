using Microsoft.AspNetCore.Mvc;
using quota.application.DTOs.Requests;
using quota.application.Interfaces;

namespace quota.api.Controllers;

[ApiController]
[Route("")]
public class QuotaController : ControllerBase
{
    private readonly IQuotaControllerHandler _quotaControllerHandler;

    public QuotaController(IQuotaControllerHandler quotaControllerHandler)
    {
        _quotaControllerHandler = quotaControllerHandler;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await _quotaControllerHandler.HandleAsync(new QuotaHttpRequest());
        return Ok(response);
    }
    
}