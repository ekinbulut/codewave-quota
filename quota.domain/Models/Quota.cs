namespace quota.domain.Models;

public class Quota : BaseModel
{
    public string UserId { get; set; }
    public int Limit { get; set; }
    public bool Exceed { get; set; }
}