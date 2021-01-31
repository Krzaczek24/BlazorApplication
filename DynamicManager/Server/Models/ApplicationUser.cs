using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicManager.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string LastName { get; set; }
    }
}
