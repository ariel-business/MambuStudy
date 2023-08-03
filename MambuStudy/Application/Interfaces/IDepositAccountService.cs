using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositAccountService
    {
        Task<ApiResult<List<DepositAccountResponse>>> Get(int? limit, int? offset);
        Task<ApiResult<DepositAccountResponse>> Create(CreateDepositAccountRequest depositAccountRequest);
        Task<ApiResult<DepositAccountResponse>> GetById(string depositAccountId);
        Task<ApiResult<object>> Delete(string depositAccountId);
    }
}
