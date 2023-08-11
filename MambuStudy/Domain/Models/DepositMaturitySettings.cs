namespace MambuStudy.Domain.Models
{
    public class DepositMaturitySettings
    {
        public IntegerInterval? MaturityPeriod { get; set; }
        public string? MaturityPeriodUnit { get; set; }
    }
}
