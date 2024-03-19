namespace quota.domain.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
}