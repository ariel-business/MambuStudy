using MambuStudy.Domain.Models;

namespace MambuStudy.Application.ViewModel.Response
{
    public class DepositProductResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DepositProductAccountingSettings AccountingSettings { get; set; }
        public DepositNewAccountSettings NewAccountSettings { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
    }
}
