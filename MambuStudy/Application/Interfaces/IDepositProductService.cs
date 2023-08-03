using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositProductService
    {
        Task<ApiResult<List<DepositProductResponse>>> Get(int? limit, int? offset, string? detailsLevel = "FULL");
    }
}
