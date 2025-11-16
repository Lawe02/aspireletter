using Supalib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Interface
{
    public interface IResumeRepository
    {
        public Task SaveResumeAsync(Resume resume);
        public Task<Resume> GetResumeAsync(string userId, int resumeId);
        public Task<List<Resume>> GetResumesAsync(string userId);
    }
}
