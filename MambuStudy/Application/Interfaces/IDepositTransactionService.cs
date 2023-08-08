using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Enums;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositTransactionService
    {
        Task<ApiResult<DepositTransactionResponse>> GetById(string depositTransactionId, DetailsLevel? detailsLevel);
    }
}
