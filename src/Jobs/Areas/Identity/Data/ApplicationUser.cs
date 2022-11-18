using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jobs.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(32)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(32)")]
        public string LastName { get; set; }

        [PersonalData]
        public string UserBio { get; set; }

        [PersonalData]
        public string AddressLine { get; set; }

        public string AdditionalAddress { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Estate { get; set; }

        public string AreaCode { get; set; }
    }
}
