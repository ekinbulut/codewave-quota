using quota.application.DTOs.Requests;
using quota.application.DTOs.Responses;

namespace quota.application.Interfaces;

public interface IQuotaControllerHandler
{
    Task<QuotaHttpResponse> HandleAsync(QuotaHttpRequest request);
}