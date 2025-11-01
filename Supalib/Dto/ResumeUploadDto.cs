using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Supalib.Dto
{
    public class ResumeUploadDto
    {
        [Required]
        public IFormFile File { get; set; }
    }
}  
