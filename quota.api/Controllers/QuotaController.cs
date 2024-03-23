using Microsoft.AspNetCore.Mvc;
using quota.application.DTOs.Requests;
using quota.application.DTOs.Responses;
using quota.application.Interfaces;

namespace quota.api.Controllers;

[ApiController]
[Route("api/v1/quota")]
public class QuotaController : ControllerBase
{
    private readonly IQuotaControllerHandler _quotaControllerHandler;

    public QuotaController(IQuotaControllerHandler quotaControllerHandler)
    {
        _quotaControllerHandler = quotaControllerHandler;
    }

    [HttpGet]
    [ProducesResponseType(typeof(QuotaHttpResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAsync([FromQuery] string id)
    {
        var response = await _quotaControllerHandler.HandleAsync(new QuotaHttpRequest()
        {
            Id = id
        });
        return Ok(response);
    }

    [HttpGet("{userId}")]
    [ProducesResponseType(typeof(QuotaHttpResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByUserIdAsync([FromRoute] string userId)
    {
        var response = await _quotaControllerHandler.HandleAsync(new QuotaHttpRequest()
        {
            UserId = userId
        });
        return Ok(response);
    }
}