namespace MambuStudy.Domain.Models
{
    public class DepositProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DepositProductAccountingSettings AccountingSettings { get; set; }
        public DepositNewAccountSettings NewAccountSettings { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public DepositProductAvailabilitySettings? AvailabilitySettings { get; set; }
        public string? Category { get; set; }
        public string? CreationDate { get; set; }
        public CreditArrangementSettings? CreditArrangementSettings { get; set; }
        public DepositProductCurrencySettings? CurrencySettings { get; set; }
        public string? EncodedKey { get; set; }
        public DepositProductFeeSettings? FeesSettings { get; set; }
        public DepositProductInterestSettings? InterestSettings { get; set; }
        public DepositProductInternalControls? InterestControls { get; set; }
        public string? LastModifiedDate { get; set; }
        public DepositMaturitySettings? MaturitySettings { get; set; }
        public string? Notes { get; set; }
        public DepositProductOffsetSettings? OffsetSettings { get; set; }
        public OverdraftInterestSettings? OverdraftInterestSettings { get; set; }
        public DepositProductOverdraftSettings? OverdraftSettings { get; set; }
        public DepositProductTaxSettings? TaxSettings { get; set; }
        public List<DocumentTemplate>? Templates { get; set; }


    }
}
