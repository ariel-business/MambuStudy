using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositAccountService
    {
        Task<ApiResult<List<DepositAccountResponse>>> GetAll(int? limit, int? offset, string? detailsLevel);
        Task<ApiResult<DepositAccountResponse>> Create(CreateDepositAccountRequest depositAccountRequest);
        Task<ApiResult<DepositAccountResponse>> GetById(string depositAccountId, string? detailsLevel);
        Task<ApiResult<object>> Delete(string depositAccountId);
        Task<ApiResult<DepositAccountResponse>> ChangeDepositAccountState(string depositAccountId, ChangeDepositAccountStateRequest changeDepositAccountStateRequest);
        Task<ApiResult<List<DepositTransactionResponse>>> GetAllTransactions(string depositAccountId, int? limit, int? offset, string? detailsLevel);
        Task<ApiResult<DepositTransactionResponse>> MakeDeposit(string depositAccountId, MakeDepositTransactionRequest makeDepositTransactionRequest);
    }
}
