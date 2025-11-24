using Supalib.Dto;
using Supalib.Dto.Response;

namespace Supalib.Interface
{
    public interface IResumeService
    {
        public Task UploadResumeAsync(ResumeUploadDto dto, string userid);
        public Task<ResumeListViewModel> GetResumesAsync(string userId);
    }
}
