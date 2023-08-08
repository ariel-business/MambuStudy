namespace MambuStudy.Domain.Models
{
    public class DepositProductAccountingSettings
    {
        public string AccountingMethod { get; set; }
        public List<DepositGLAccountingRule>? AccountingRules { get; set; }
        public string? InterestAccruedAccountingMethod { get; set; }
    }
}
