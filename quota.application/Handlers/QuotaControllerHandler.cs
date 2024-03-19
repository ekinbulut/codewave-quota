using quota.application.DTOs.Requests;
using quota.application.DTOs.Responses;
using quota.application.Interfaces;

namespace quota.application.Handlers;

public class QuotaControllerHandler: IQuotaControllerHandler
{
    public async Task<QuotaHttpResponse> HandleAsync(QuotaHttpRequest request)
    {
        throw new NotImplementedException();
    }
}