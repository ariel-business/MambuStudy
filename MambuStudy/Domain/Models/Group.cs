namespace MambuStudy.Domain.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string EncodedKey { get; set; }
        public string GroupName { get; set; }
        public string? EmailAddress { get; set; }
        public string? AssignedBranchKey { get; set; }
        public string? AssignedCentrehKey { get; set; }
        public string? AssignedUserKey { get; set; }
        public IList<Address>? Addresses { get; set; }
        public string? CreationDate { get; set; }
        public List<GroupMembers>? GroupMembers { get; set; }
        public string? GroupRoleKey { get; set; }
        public string? HomePhone { get; set; }
        public string? LastModifiedDate { get; set; }
        public string? LoanCycle { get; set; }
        public string? MigrationEventKey { get; set; }
        public string? MobilePhone { get; set; }
        public string? Notes { get; set; }
        public string? PreferredLanguage { get; set; }
       
    }
}
