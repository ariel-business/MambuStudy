namespace MambuStudy.Domain.Models
{
    public class DepositTransactionInput
    {
        public double Amount { get; set; }
        public string? BookingDate { get; set; }
        public string? ExternalId { get; set; }
        public string? HoldExternalReferenceId { get; set; }
        public string? Notes { get; set; }
        public PaymentDetails? PaymentDetails { get; set; }
        public string? PaymentOrderId { get; set; }
        public bool? SkipMaximumBalanceValidation { get; set; }
        public TransactionDetailsInput? TransactionDetails { get; set; }
        public string? ValueDate { get; set; }

    }
}
