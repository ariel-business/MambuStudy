using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositTransactionService
    {
        Task<ApiResult<DepositTransactionResponse>> GetById(string depositTransactionId);
    }
}
