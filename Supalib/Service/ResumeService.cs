using Supalib.Dto;
using Supalib.Models;
using Supalib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Service
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _repo;

        public ResumeService(IResumeRepository repo) 
        {
            _repo = repo;
        }
        public async Task UploadResumeAsync(ResumeUploadDto dto, string userId)
        {
            var resume = new Resume
            {
                UserId = userId,
                FileName = dto.File.FileName,
                ContentType = dto.File.ContentType,
                Size = dto.File.Length,
                UploadedAt = DateTimeOffset.UtcNow,
            };

            using var ms = new MemoryStream();
            await dto.File.CopyToAsync(ms);
            resume.Data = ms.ToArray();
            await _repo.SaveResumeAsync(resume);
        }
    }
}
