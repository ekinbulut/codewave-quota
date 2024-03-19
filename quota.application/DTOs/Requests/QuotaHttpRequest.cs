using quota.domain.Models;

namespace quota.application.DTOs.Requests;

public class QuotaHttpRequest : BaseRequest
{
    public string Id { get; set; }
}