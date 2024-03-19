namespace quota.domain.Models;

public abstract class BaseRequest
{
    public Guid TransactionId { get; set; } = Guid.NewGuid();
}