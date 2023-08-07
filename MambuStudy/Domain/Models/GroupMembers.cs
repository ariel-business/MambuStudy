namespace MambuStudy.Domain.Models
{
    public class GroupMembers
    {
        public string ClientKey { get; set; }
        public List<GroupRole>? Roles { get; set; }
    }
}
