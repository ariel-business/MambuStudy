using MambuStudy.Domain.Models;

namespace MambuStudy.Application.ViewModel.Request
{
    public class CreateGroupRequest
    {
        public string GroupName { get; set; }
        public List<GroupMembers>? GroupMembers { get; set; }
    }
}
