namespace quota.application.DTOs.Responses;

public class QuotaHttpResponse
{
    public string Id { get; set; }
    public int Remaining { get; set; }
    public DateTime Expiring { get; set; }
}