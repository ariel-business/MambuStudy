using MambuStudy.Domain.Models;
using Newtonsoft.Json;

namespace MambuStudy.Application.ViewModel.Response
{
    public class GroupResponse
    {
        public string Id { get; set; }
        public string EncodedKey { get; set; }
        public string GroupName { get; set; }
        public List<GroupMembers> GroupMembers { get; set; }
    }
}
