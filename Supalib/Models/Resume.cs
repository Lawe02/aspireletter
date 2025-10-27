using System.ComponentModel.DataAnnotations.Schema;

namespace Supalib.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
    }
}