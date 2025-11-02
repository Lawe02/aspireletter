using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supalib.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required, MaxLength(255)]
        public string FileName { get; set; }

        [MaxLength(100)]
        public string ContentType { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] Data { get; set; } = null!;
        public long Size { get; set; }
        public string Content { get; set; }
        public DateTimeOffset UploadedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
    }
}