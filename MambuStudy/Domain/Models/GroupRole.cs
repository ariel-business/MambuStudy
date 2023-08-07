using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace MambuStudy.Domain.Models
{
    public class GroupRole
    {
        public string GroupRoleNameKey { get; set; }
        public string? EncodedKey { get; set; }
        public string? RoleName { get; set; }
        public string? RoleNameId { get; set; }
    }
}