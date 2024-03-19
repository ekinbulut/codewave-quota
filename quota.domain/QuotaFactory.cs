using quota.domain.Models;

namespace quota.domain;

public class QuotaFactory
{
    private static Quota _quota;

    public static Quota CreateInstance()
    {
        _quota = new Quota();
        return _quota; 
    }
}