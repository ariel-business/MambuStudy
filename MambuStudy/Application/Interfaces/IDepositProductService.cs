using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Enums;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositProductService
    {
        Task<ApiResult<List<DepositProductResponse>>> GetAll(int? limit, int? offset, DetailsLevel? detailsLevel);
        Task<ApiResult<DepositProductResponse>> GetById(string depositProductId, DetailsLevel? detailsLevel);
    }
}
