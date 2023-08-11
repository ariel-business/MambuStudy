namespace MambuStudy.Application.ViewModel.Response
{
    public class DepositAccountResponse
    {
        public string Id { get; set; }
        public string EncodedKey { get; set; }
        public string Name { get; set; }
        public string AccountHolderKey { get; set; }
        public string AccountHolderType { get; set; }
        public string ProductTypeKey { get; set; }
        public string? AccountState { get; set; }
        public string? AccountType { get; set; }
        public string? CreationDate { get; set; }
        public string? ApprovedDate { get; set; }
        public string? ActivationDate { get; set; }
        public string? MaturityDate { get; set; }
    }
}
