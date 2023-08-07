﻿using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IGroupService
    {
        Task<ApiResult<List<GroupResponse>>> GetAll(int? limit, int? offset);
        Task<ApiResult<GroupResponse>> Create(CreateGroupRequest groupRequest);
        Task<ApiResult<GroupResponse>> GetById(string groupId, string detailsLevel = "BASIC");
    }
}
