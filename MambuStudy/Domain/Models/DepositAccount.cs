namespace MambuStudy.Domain.Models
{
    public class DepositAccount
    {
        public string Name { get; set; }
        public string AccountHolderKey { get; set; }
        public string AccountHolderType { get; set; }
        public string ProductTypeKey { get; set; }
        public string? AccountState { get; set; }
        public string? AccountType { get; set; }
        public DepositAccountAccruedAmounts? AccruedAmounts { get; set; }
        public string? ActivationDate { get; set; }
        public string? ApprovedDate { get; set; }
        public string? AssignedBranchKey { get; set; }
        public string? AssignedCentreKey { get; set; }
        public string? AssignedUserKey { get; set; }
        public DepositAccountBalances? Balances { get; set; }
        public string? ClosedDate { get; set; }
        public string? CreationDate { get; set; }
        public string? CreditArrangementKey { get; set; }
        public string? CurrencyCode { get; set; }
        public string? EncodedKey { get; set; }
        public string? Id { get; set; }
        public DepositAccountInterestSettings? InterestSettings { get; set; }
        public DepositAccountInternalControls? InternalControls { get; set; }
        public string? LastAccountAppraisalDate { get; set; }
        public string? LastInterestCalculationDate { get; set; }
        public string? LastInterestReviewDate { get; set; }
        public string? LastInterestStoredDate { get; set; }
        public string? LastModifiedDate { get; set; }
        public string? LastOverdraftInterestReviewDate { get; set; }
        public string? LastSetToArrearsDate { get; set; }
        public string? LinkedSettlementAccountKeys { get; set; }
        public string? LockedDate { get; set; }
        public string? MaturityDate { get; set; }
        public string? MigrationEventKey { get; set; }
        public string? Notes { get; set; }
        public DepositAccountOverdraftInterestSettings? OverdraftInterestSettings { get; set; }
        public DepositAccountOverdraftSettings? OverdraftSettings { get; set; }
        public string? WithholdingTaxSourceKey { get; set; }
    }
}
