using Microsoft.AspNetCore.Identity;
using Supalib.Dto;
using Supalib.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Interface
{
    public interface IResumeService
    {
        public Task UploadResumeAsync(ResumeUploadDto dto, string userid);
        public Task<ResumeListViewModel> GetResumesAsync(string userId);
    }
}
