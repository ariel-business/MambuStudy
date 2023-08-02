using MambuStudy.Domain.Models;

namespace MambuStudy.Application.ViewModel.Response
{
    public class ClientResponse
    {
        public string? Id { get; set; }
        public IList<IdentificationDocument>? IdDocuments { get; set; }
        public string? EncodedKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? EmailAddress { get; set; }
        public string? State { get; set; }
        public string? Gender { get; set; }
        public string? BirthDate { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? MobilePhone2 { get; set; }
        public string? LoanCycle { get; set; }
        public string? ActivationDate { get; set; }
        public string? ApprovedDate { get; set; }
        public string? AssignedBranchKey { get; set; }
        public string? AssignedCentrehKey { get; set; }
        public string? AssignedUserKey { get; set; }
        public string? ClientRoleKey { get; set; }
        public string? GroupKeys { get; set; }
        public string? GroupLoanCycle { get; set; }
        public string? ClosedDate { get; set; }
        public string? CreationDate { get; set; }
        public string? LastModifiedDate { get; set; }
        public string? MigrationEventKey { get; set; }
        public string? Notes { get; set; }
        public PortalSettings? PortalSettings { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? ProfilePictureKey { get; set; }
        public string? ProfileSignatureKey { get; set; }
        public IList<Address>? Addresses { get; set; }
    }
}
