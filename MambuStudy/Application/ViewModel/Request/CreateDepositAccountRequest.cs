namespace MambuStudy.Application.ViewModel.Request
{
    public class CreateDepositAccountRequest
    {
        public string Name { get; set; }
        public string AccountHolderKey { get; set; }
        public string AccountHolderType { get; set; }
        public string ProductTypeKey { get; set; }
    }
}
