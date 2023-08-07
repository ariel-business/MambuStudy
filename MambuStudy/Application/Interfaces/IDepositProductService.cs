using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositProductService
    {
        Task<ApiResult<List<DepositProductResponse>>> GetAll(int? limit, int? offset, string? detailsLevel = "FULL");
        Task<ApiResult<DepositProductResponse>> GetById(string depositProducttId, string? detailsLevel = "Full");
    }
}
