using Microsoft.AspNetCore.Identity;

namespace Supalib.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Resume> Resumes { get; set; }
    }
}