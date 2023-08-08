﻿using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IDepositProductService
    {
        Task<ApiResult<List<DepositProductResponse>>> GetAll(int? limit, int? offset, string? detailsLevel);
        Task<ApiResult<DepositProductResponse>> GetById(string depositProductId, string? detailsLevel);
    }
}