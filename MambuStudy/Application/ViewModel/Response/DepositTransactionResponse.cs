using MambuStudy.Domain.Models;

namespace MambuStudy.Application.ViewModel.Response
{
    public class DepositTransactionResponse
    {
        public string EncodedKey { get; set; }
        public bool Advice { get; set; }
        public double Amount { get; set; }
        public string ExternalReferenceId { get; set; }
        public string PredefinedFeeKey { get; set; }
        public List<DepositTransaction> DepositTransactions { get; set; }
        public DepositTransactionBalances AccountBalances { get; set; }
    }
}
